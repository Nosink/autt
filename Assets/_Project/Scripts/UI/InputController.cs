using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputController : MonoBehaviour {

    [SerializeField]
    private Image mIcon;

    void Start() {
        // Listener to change alpha based on the input field content
        GetComponent<TMP_InputField>().onValueChanged.AddListener((string text) => {
            mIcon.color = new Color(1.0f, 1.0f, 1.0f, (string.IsNullOrEmpty(text)) ? 0.8f : 1.0f);
        });
    }

}