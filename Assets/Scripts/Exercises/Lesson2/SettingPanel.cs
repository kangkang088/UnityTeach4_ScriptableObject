using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingPanel : MonoBehaviour
{
    public Toggle toggleMusic;
    public Toggle toggleSound;
    public Slider sliderMusic;
    public Slider sliderSound;
    public SettingInfo info;
    // Start is called before the first frame update
    void Start()
    {
        info = ScriptableObject.CreateInstance<SettingInfo>();
        toggleMusic.isOn = info.musicIsOpen;
        toggleSound.isOn = info.soundIsOpen;
        sliderMusic.value = info.musicIntensity;
        sliderSound.value = info.soundIntensity;
        toggleMusic.onValueChanged.AddListener((v) => {
            info.musicIsOpen = v;
        });
        toggleSound.onValueChanged.AddListener((v) => {
            info.soundIsOpen = v;
        });
        sliderMusic.onValueChanged.AddListener((v) => {
            info.musicIntensity = v;
        });
        sliderSound.onValueChanged.AddListener((v) => {
            info.soundIntensity = v;
        });
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            info.Save();
        }
    }
}
