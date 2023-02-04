using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMng : MonoBehaviour
{
    public static GameObject mainMenu;
    public static GameObject newGame;
    public static GameObject optionsMenu;
    public static GameObject credits;

    [SerializeField]  AudioSource buttonSound;
    [SerializeField]  public AudioClip confirm, back, choice;

    void Start()
    {
        mainMenu = GameObject.Find("MainMenu");

        optionsMenu = GameObject.Find("OptionsMenu");
        optionsMenu.SetActive(false);

        credits = GameObject.Find("CreditsPanel");
        credits.SetActive(false);
    }

    public AudioSource getAudioSource()
    {
        return buttonSound;
    }

    public void PlayConfirmSound()
    {
        buttonSound.PlayOneShot(confirm);
    }

}
