using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Instance { get; private set; }

    public Character mSceneCharacter = null;
    private Customizer[] mCustomizer;

    // Singleton to keep character information cross scenes
    void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    private void OnSceneLoad() {
        // Find Character
        // Build customization
    }

    public void LoadGameScene() {


        Debug.Log("Load GameScene");
        // TODO: Parte 3
        // Find character
        // get customization and store temporally
    }


}