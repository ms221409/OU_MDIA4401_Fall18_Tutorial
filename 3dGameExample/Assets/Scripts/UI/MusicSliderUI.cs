using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MusicSliderUI : MonoBehaviour 
{
    public Text currentVolumeTextLabel;


    public void OnVolumeSliderChanged (float currentVolume)
    {
        currentVolumeTextLabel.text = (currentVolume * 100).ToString ("F0") + "%";
    }
}
