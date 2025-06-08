using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoginView : MonoBehaviour {

    [SerializeField, Header("Input Fields")]
    private TMP_InputField mEmailInput;
    [SerializeField]
    private TMP_InputField mPasswordInput;

    [SerializeField, Header("Error Handler")]
    private TMP_Text mErrorText;

    [SerializeField, Header("Login Button")]
    private Button mLoginButton;

    private LoginController mController;

    private void Awake() {
        mController = new LoginController();

        mLoginButton.onClick.AddListener(OnLoginClicked);
        mEmailInput.onDeselect.AddListener(OnDeselectEmailInput);
    }

    private void OnLoginClicked() {
        bool lValidEmail = Validator.IsValidEmail(mEmailInput.text);
        bool lValidPassword = Validator.IsValidPassword(mPasswordInput.text);

        if (!(lValidEmail && lValidPassword)) {
            mErrorText.text = "E-mail or Password incorrect.";
        } else {
            mController.HandleLogin(mEmailInput.text, mPasswordInput.text);
        }
    }

    private void OnDeselectEmailInput(string email) {
        mErrorText.text = Validator.IsValidEmail(email) ? "" : "E-mail not valid.";
    }

}