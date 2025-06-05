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
        emailInput.onValueChanged.AddListener(OnEmailValueChanged);
        passwordInput.onValueChanged.AddListener(OnPasswordValueChanged);
    }

    private void OnLoginClicked() {
        controller.HandleLogin(emailInput.text, passwordInput.text);
    }

    private void OnEmailValueChanged(string email) {
        errorText.text = "";
        if (Validator.IsValidEmail(email))
            return;

        errorText.text = "Invalid E-Mail";
    }

    private void OnPasswordValueChanged(string password) {
        loginButton.enabled = !Validator.IsPasswordEmpty(password);
    }

}
