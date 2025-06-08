using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Instance { get; private set; }

    private Character mSceneCharacter;
    private Customization[] mCustomization = null;

    void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public void SetSceneCharacter(Character character) {
        mSceneCharacter = character;
        if (mCustomization != null)
            mSceneCharacter.BuildCharacterCustomization(mCustomization);

    }

    public void LoadGameScene() {
        if (mSceneCharacter != null)
            mCustomization = mSceneCharacter.GetCharacterCustomization();
        SceneLoader.Instance.LoadSceneAsync("GameScene");
    }

    public void LoadLobbyScene() {
        if (mSceneCharacter != null)
            mCustomization = mSceneCharacter.GetCharacterCustomization();
        SceneLoader.Instance.LoadSceneAsync("LobbyScene");
    }

}