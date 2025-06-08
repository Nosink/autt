using UnityEngine;

public class Customizer : MonoBehaviour {

    private int mIndex;
    private Transform[] mCustomizables;

    [SerializeField]
    private CustomizablePart mCustomizablePart;

    // Find and disable all child elements except the 
    // first one, way to keep and track all customizables items
    void Awake() {
        mIndex = 0;
        mCustomizables = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++) {
            Transform child = transform.GetChild(i);
            mCustomizables[i] = child;
            child.gameObject.SetActive(i == mIndex);
        }
    }

    public void SetCustomization(int index, CustomizablePart part) {
        mCustomizablePart = part;
        SetCustomizableIndex(index);
    }

    public void SetCustomizableIndex(int index) {
        ToggleItem(mIndex, index);
    }

    public void NextCustomizable() {
        SetCustomizableIndex((mIndex + 1) % mCustomizables.Length);
    }

    public void PreviousCustomizable() {
        SetCustomizableIndex((mIndex - 1 + mCustomizables.Length) % mCustomizables.Length);
    }

    private void ToggleItem(int previous, int next) {
        mIndex = next;
        mCustomizables[previous].gameObject.SetActive(false);
        mCustomizables[next].gameObject.SetActive(true);
    }

    public Customization GetCustomization() {
        return new Customization(mIndex, mCustomizablePart);
    }

}
