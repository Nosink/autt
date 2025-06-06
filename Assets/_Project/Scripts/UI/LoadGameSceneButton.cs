using UnityEngine;
using UnityEngine.UI;

public class LoadGameSceneButton : MonoBehaviour {

    void Start() {
        GetComponent<Button>().onClick.AddListener(() => {
            GameManager.Instance.LoadGameScene();
        });
    }

}