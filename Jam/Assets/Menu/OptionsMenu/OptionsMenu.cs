using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class OptionsMenu : MonoBehaviour
{
    public MenuMng mng;
    public TextMeshProUGUI brightnessValue;

    private void Start()
    {
        mng = GameObject.Find("MenuMng").GetComponent<MenuMng>();
    }

    public void BackToMainMenu()
    {
        mng.getAudioSource().PlayOneShot(mng.back);
        MenuMng.optionsMenu.SetActive(false);
        MenuMng.mainMenu.SetActive(true);
    }

    public void IncreaseBrightness()
    {
        int index = int.Parse(brightnessValue.text);
        index++;
        index = Mathf.Clamp(index, 1, 5);
        PlayerPrefs.SetInt("Brightness", index);
        brightnessValue.text = index.ToString();
    }

    public void DecreaseBrightness()
    {
        int index = int.Parse(brightnessValue.text);
        index--;
        index = Mathf.Clamp(index, 1, 5);
        PlayerPrefs.SetInt("Brightness", index);
        brightnessValue.text = index.ToString();
    }
}
