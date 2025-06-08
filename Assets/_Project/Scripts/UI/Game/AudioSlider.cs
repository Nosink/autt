using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AudioSlider : MonoBehaviour {

    private Slider mSlider;

    [SerializeField]
    private TMP_Text mText;

    void Start() {
        mSlider = GetComponent<Slider>();
    }

    public void SetValue(float value) {
        mSlider.value = value;
    }

    public void SetTimes(float current, float total) {
        mText.text = FormatTime(current) + " - " + FormatTime(total);
    }

    private string FormatTime(float seconds) {
        TimeSpan lTimeSpan = TimeSpan.FromSeconds(seconds);
        return $"{lTimeSpan.Minutes:00}:{lTimeSpan.Seconds:00}";
    }

}