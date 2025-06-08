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
    private PopUpPanel mPanel;
    [SerializeField]
    private Button mReturnToLobbyButton;

    void Start() {
        mPlayButton.GetComponent<Button>().onClick.AddListener(OnClickPlayButton);
        mReturnToLobbyButton.onClick.AddListener(() => GameManager.Instance.LoadLobbyScene());

        AudioController.OnAudioEnd += () => mPanel.Show();
        AudioController.OnAudioEnd += mPlayButton.SetPlaySprite;
    }

    public void OnClickPlayButton() {
        if (mAudioController.IsPlaying()) {
            mAudioController.Puase();
            mPlayButton.SetPlaySprite();
        } else {
            mAudioController.Play();
            mPlayButton.SetPauseSprite();
        }
    }

    void Update() {
        mAudioSlider.SetValue(mAudioController.GetNormalizedPlaybackTime());
        mAudioSlider.SetTimes(mAudioController.GetPlaybackTime(), mAudioController.GetTotalTime());
    }

}
