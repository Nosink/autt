using UnityEngine;

public class LobbyView : MonoBehaviour {


    private LobbyController controller;

    [SerializeField]
    private CameraController cameraController;

    void Start() {
        controller = new LobbyController(this, cameraController);
    }

    public void SetCameraTargetPosition(Transform target) {
        controller.SetCameraTargetPosition(target);
    }
}