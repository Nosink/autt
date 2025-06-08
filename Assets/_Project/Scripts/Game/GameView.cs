using UnityEngine;
using UnityEngine.UI;

public class GameView : MonoBehaviour {

    [SerializeField]
    private PlayButton mPlayButton;

    [SerializeField]
    private AudioController mAudioController;

    [SerializeField]
    private Transform mPanel;

    [SerializeField]
    private AudioSlider mAudioSlider;

    void Start() {
        mPanel.gameObject.SetActive(false);
        mPlayButton.GetComponent<Button>().onClick.AddListener(OnClickPlayButton);
        AudioController.OnAudioEnd += DisplayPanel;
        AudioController.OnAudioEnd += mPlayButton.SetPlaySprite;
    }

    private void DisplayPanel() {
        mPanel.gameObject.SetActive(true);
    }

    public void OnClickPlayButton() {
        if (mAudioController.IsPlaying()) {
            mPlayButton.SetPlaySprite();
            mAudioController.Puase();
        } else {
            mPlayButton.SetPauseSprite();
            mPanel.gameObject.SetActive(false);
            mAudioController.Play();
        }
    }

    void Update() {
        mAudioSlider.SetValue(mAudioController.GetNormalizedPlaybackTime());
        mAudioSlider.SetTimes(mAudioController.GetPlaybackTime(), mAudioController.GetTotalTime());
    }

}
