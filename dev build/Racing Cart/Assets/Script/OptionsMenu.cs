using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioManager audioManager;

    private void Start()
    {
        // Set the slider value to the current volume level
        volumeSlider.value = audioManager.GetVolume();
    }

    // This method is called when the slider value changes
    public void OnVolumeChanged()
    {
        float volume = volumeSlider.value;
        audioManager.SetVolume(volume);
    }
}
