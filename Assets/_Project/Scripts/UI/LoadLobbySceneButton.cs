using UnityEngine;
using UnityEngine.UI;

public class LoadLobbySceneButton : MonoBehaviour {

    void Start() {
        GetComponent<Button>().onClick.AddListener(() => {
            GameManager.Instance.LoadLobbyScene();
        });
    }

}
