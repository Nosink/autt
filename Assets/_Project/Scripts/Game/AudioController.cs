using System;
using System.Collections;
using UnityEngine;

public class AudioController : MonoBehaviour {

    /* OnAudioEnd callback */
    public static event Action OnAudioEnd;

    private AudioSource mSource;
    private bool mPaused = false;

    void Start() {
        mSource = GetComponent<AudioSource>();
    }

    public void Play() {
        mSource.Play();
        mPaused = false;
        StartCoroutine(AudioMonitor());
    }

    private IEnumerator AudioMonitor() {
        yield return new WaitWhile(() => mSource.isPlaying || mPaused);
        OnAudioEnd?.Invoke();
    }

    public void Puase() {
        mSource.Pause();
        mPaused = true;
    }

    public bool IsPlaying() {
        return mSource != null && mSource.isPlaying;
    }

    public float GetPlaybackTime() {
        return mSource.time;
    }

    public float GetTotalTime() {
        return mSource.clip.length;
    }

    public float GetNormalizedPlaybackTime() {
        return (mSource.time / mSource.clip.length);
    }

}