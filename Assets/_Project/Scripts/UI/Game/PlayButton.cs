using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour {

    [SerializeField]
    private Image mImage;

    [SerializeField, Header("Sprites:")]
    private Sprite mPlaySprite;
    [SerializeField]
    private Sprite mPauseSprite;

    public void SetPlaySprite() {
        mImage.sprite = mPlaySprite;
    }

    public void SetPauseSprite() {
        mImage.sprite = mPauseSprite;
    }

}