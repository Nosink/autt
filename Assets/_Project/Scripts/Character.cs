using UnityEngine;

public class Character : MonoBehaviour {

    [SerializeField]
    private Customizer[] mCustomizer;

    public void BuildCharacterCustomization(Customization[] customization) {
        for (int i = 0; i < customization.Length; i++)
            mCustomizer[i].SetCustomization(customization[i].index, customization[i].part);
    }

    public Customization[] GetCharacterCustomization() {
        Customization[] customization = new Customization[mCustomizer.Length];
        for (int i = 0; i < mCustomizer.Length; i++)
            customization[i] = mCustomizer[i].GetCustomization();
        return customization;
    }

}
