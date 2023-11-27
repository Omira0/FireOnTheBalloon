using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        save();
    }
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("MusicVolume");

    }
    private void save()
    {
        PlayerPrefs.SetFloat("MusicVolume", volumeSlider.value);
    }
}
