using UnityEngine;
using UnityEngine.UI;

public class GameView : MonoBehaviour {

    [SerializeField, Header("Audio Controller")]
    private AudioController mAudioController;
    [SerializeField]
    private PlayButton mPlayButton;
    [SerializeField]
    private AudioSlider mAudioSlider;

    [SerializeField, Header("PopUp Panel")]
    private Transform mPanel;
    [SerializeField]
    private Button mReturnToLobbyButton;

    void Start() {
        mPanel.gameObject.SetActive(false);

        mPlayButton.GetComponent<Button>().onClick.AddListener(OnClickPlayButton);
        mReturnToLobbyButton.onClick.AddListener(() => GameManager.Instance.LoadLobbyScene());

        AudioController.OnAudioEnd += DisplayPopUpPanel;
        AudioController.OnAudioEnd += mPlayButton.SetPlaySprite;
    }

    private void DisplayPopUpPanel() {
        mPanel.gameObject.SetActive(true);
    }

    public void OnClickPlayButton() {
        if (mAudioController.IsPlaying()) {
            mAudioController.Puase();
            mPlayButton.SetPlaySprite();
        } else {
            mAudioController.Play();
            mPlayButton.SetPauseSprite();
            mPanel.gameObject.SetActive(false);
        }
    }

    void Update() {
        mAudioSlider.SetValue(mAudioController.GetNormalizedPlaybackTime());
        mAudioSlider.SetTimes(mAudioController.GetPlaybackTime(), mAudioController.GetTotalTime());
    }

}
