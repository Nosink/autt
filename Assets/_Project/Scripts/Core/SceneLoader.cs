using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    /* OnSceneLoad observer */
    public static event Action OnSceneLoaded;

    /* Singleton Instance */
    public static SceneLoader Instance { get; private set; }

    private AsyncOperation mAsyncOp;

    private Animator mAnimator;

    /* Unity Awake */
    void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    /* Unity Start */
    void Start() {
        mAnimator = GetComponentInChildren<Animator>();
    }

    public void LoadSceneAsync(string sceneName) {
        mAnimator.SetTrigger("fadeIn");
        StartCoroutine(CoroLoadSceneAsync(sceneName));
    }

    private IEnumerator CoroLoadSceneAsync(string sceneName) {

        // wait for fade in animation ends
        while (!mAnimator.GetCurrentAnimatorStateInfo(0).IsName("crossfade_start") ||
            mAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f) {
            yield return null;
        }

        mAsyncOp = SceneManager.LoadSceneAsync(sceneName);
        mAsyncOp.allowSceneActivation = true;
        while (!mAsyncOp.isDone && mAsyncOp.progress < 0.9f) {
            yield return null;
        }
        OnSceneLoaded?.Invoke();

        // Start fade out animation
        mAnimator.SetTrigger("fadeOut");
    }

}
