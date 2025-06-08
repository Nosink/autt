using UnityEngine;

public class PopUpPanel : MonoBehaviour {

    private Animator mAnimator;

    void Start() {
        mAnimator = GetComponent<Animator>();
    }

    public void Show() {
        mAnimator.SetTrigger("Show");
    }

}