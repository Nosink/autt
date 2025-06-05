using UnityEngine;

public class LoginController {

    private AuthService authService;

    public LoginController() {
        authService = new AuthService();
    }

    public void HandleLogin(string email, string password) {
        if (!Validator.IsValidEmail(email))
            return;

        authService.Login(email, password, OnLoginSuccess);
    }

    private void OnLoginSuccess() {
        Debug.Log("Login Success");
        // TODO: Parte 2
    }

}