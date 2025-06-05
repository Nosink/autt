using System;

public class AuthService {

    // Simulates external api call for login comprobations
    // Only invoce the Success to allow test continues flows
    public void Login(string email, string password, Action onSuccess) {
        onSuccess?.Invoke();
    }

}
