using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CustomizationPanel : MonoBehaviour, IPointerEnterHandler {

    [SerializeField]
    private Transform targetCameraPosition;

    [SerializeField]
    private LobbyView view;

    [SerializeField]
    private Customizer customizer;

    [SerializeField]
    private Button increaseButton;
    [SerializeField]
    private Button decreaseButton;

    [SerializeField]
    private CustomizablePart customizablePart;

    void Start() {
        increaseButton.onClick.AddListener(customizer.Increase);
        decreaseButton.onClick.AddListener(customizer.Decrease);
    }

    public void OnPointerEnter(PointerEventData _) {
        view.SetCameraTargetPosition(targetCameraPosition);
    }

}
