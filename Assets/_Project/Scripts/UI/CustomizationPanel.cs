using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CustomizationPanel : MonoBehaviour, IPointerEnterHandler {

    [Header("Camera"), SerializeField]
    private CameraController mCameraController;

    [SerializeField]
    private Transform mTargetCameraPosition;

    [Header("Customization"), SerializeField]
    private Customizer mCustomizer;

    [Header("Controller Buttons"), SerializeField]
    private Button mNext;
    [SerializeField]
    private Button mPrevious;

    void Start() {
        mNext.onClick.AddListener(mCustomizer.NextCustomizable);
        mPrevious.onClick.AddListener(mCustomizer.PreviousCustomizable);
    }

    public void OnPointerEnter(PointerEventData _) {
        mCameraController.MoveTo(mTargetCameraPosition);
    }


}
