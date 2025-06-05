using UnityEngine;

public class LobbyController {

    private LobbyView view;
    private CameraController cameraController;

    public LobbyController(LobbyView view, CameraController cameraController) {
        this.view = view;
        this.cameraController = cameraController;
    }

    public void SetCameraTargetPosition(Transform target) {
        cameraController.SetTargetPosition(target);
    }

}