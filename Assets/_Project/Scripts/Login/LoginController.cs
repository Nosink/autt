using UnityEngine;

public class LoginController {

    private AuthService mAuthService;

    public LoginController() {
        mAuthService = new AuthService();
    }

    public void HandleLogin(string email, string password) {
        _ = mAuthService.Login(email, password, OnLoginSuccess, OnLoginFailure);
    }

    private void OnLoginSuccess() {
        GameManager.Instance.LoadLobbyScene();
    }

    private void OnLoginFailure(string error) {
        Debug.LogError(error);
    }

}