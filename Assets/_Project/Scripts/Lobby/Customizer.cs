using UnityEngine;



public class Customizer : MonoBehaviour {

    private int index;
    private Transform[] items;

    void Start() {
        index = 0;
        items = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++) {
            Transform child = transform.GetChild(i);
            items[i] = child;
            child.gameObject.SetActive(i == index);
        }
    }

    public void Increase() {
        ToggleItem(index, (index + 1) % items.Length);
    }
    public void Decrease() {
        ToggleItem(index, (index - 1 + items.Length) % items.Length);
    }

    public void ToggleItem(int previous, int next) {
        index = next;
        items[previous].gameObject.SetActive(false);
        items[next].gameObject.SetActive(true);
    }

}
