using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoginView : MonoBehaviour {

    [SerializeField]
    private TMP_InputField emailInput;
    [SerializeField]
    private TMP_InputField passwordInput;
    [SerializeField]
    private TMP_Text errorText;
    [SerializeField]
    private Button loginButton;

    private LoginController controller;

    private void Awake() {
        controller = new LoginController();

        loginButton.onClick.AddListener(OnLoginClicked);
        emailInput.onDeselect.AddListener(OnDeselectEmailInput);
    }

    private void OnLoginClicked() {

        bool validEmail = Validator.IsValidEmail(emailInput.text);
        bool validPassword = Validator.IsValidPassword(passwordInput.text);

        if (!(validEmail && validPassword)) {
            errorText.text = "E-mail or Password incorrect.";
        } else {
            controller.HandleLogin(emailInput.text, passwordInput.text);
        }
    }

    private void OnDeselectEmailInput(string email) {
        errorText.text = Validator.IsValidEmail(email) ? "" : "E-mail not valid.";
    }

}