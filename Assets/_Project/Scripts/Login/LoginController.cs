using UnityEngine;

public class LoginController {

    private AuthService mAuthService;

    public LoginController() {
        mAuthService = new AuthService();
    }

    public void HandleLogin(string email, string password) {
        if (!Validator.IsValidEmail(email))
            return;

        mAuthService.Login(email, password, OnLoginSuccess);
    }

    private void OnLoginSuccess() {
        Debug.Log("Login Success");
        // TODO: Parte 2
    }

}