using UnityEngine;
using UnityEngine.UI;

public class LobbyView : MonoBehaviour {

    [SerializeField, Header("Character")]
    private Character mCharacter;

    [SerializeField, Header("Camera")]
    private CameraController mCameraController;
    [SerializeField]
    private Transform mUpperPosition;
    [SerializeField]
    private Transform mLowerPosition;

    [SerializeField, Header("Customization Panel")]
    private GameObject mUICustomizationPanelPrefab;

    [SerializeField, Header("Load Game Button")]
    private Button mLoadLobbySceneButton;

    void Start() {
        mLoadLobbySceneButton.onClick.AddListener(() => GameManager.Instance.LoadGameScene());

        foreach (Customizer customizer in mCharacter.Customizers) {
            GameObject
                .Instantiate(mUICustomizationPanelPrefab, this.transform)
                .GetComponent<CustomizationPanel>()
                .SetPanel(customizer, mCameraController, customizer.Zone == CustomizableZone.Lower ? mLowerPosition : mUpperPosition);
        }

    }

}