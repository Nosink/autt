using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CustomizationPanel : MonoBehaviour, IPointerEnterHandler {

    private CameraController mCameraController;
    private Transform mTargetCameraPosition;
    private Customizer mCustomizer;

    [SerializeField, Header("Text")]
    private TMP_Text mText;

    [SerializeField, Header("Controller Buttons")]
    private Button mNext;
    [SerializeField]
    private Button mPrevious;

    public void SetPanel(Customizer customizer, CameraController cameraController, Transform targetCameraPosition) {
        mCustomizer = customizer;
        mCameraController = cameraController;
        mTargetCameraPosition = targetCameraPosition;

        ActivePanel();
    }

    private void ActivePanel() {
        mNext.onClick.AddListener(mCustomizer.NextCustomizable);
        mPrevious.onClick.AddListener(mCustomizer.PreviousCustomizable);

        mText.text = mCustomizer.gameObject.name;
    }

    public void OnPointerEnter(PointerEventData _) {
        mCameraController.MoveTo(mTargetCameraPosition);
    }

}