using System;
using System.Threading.Tasks;

public class AuthService {

    public async Task Login(string email, string password, Action onSuccess, Action<String> onFailure) {

        await Task.Delay(500);

        bool lUserExists = SimulateUserExists(email);
        if (!Validator.IsValidEmail(email) || !lUserExists) {
            onFailure?.Invoke("Invalid e-mail");
            return;
        }

        bool lPasswordCorrect = SimulateCheckPassword(email, password);
        if (!Validator.IsValidPassword(password) || !lPasswordCorrect) {
            onFailure?.Invoke("Invalid Password");
            return;
        }

        if (lUserExists && lPasswordCorrect) {
            onSuccess?.Invoke();
        } else {
            onFailure?.Invoke("Unknow Error");
        }

    }

    private bool SimulateUserExists(string email) {
        return true;
    }

    private bool SimulateCheckPassword(string email, string password) {
        return true;
    }

}