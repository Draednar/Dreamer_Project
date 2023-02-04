using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public MenuMng mng;

    private void Start()
    {
        mng = GameObject.Find("MenuMng").GetComponent<MenuMng>();
    }

    // Start is called before the first frame update
    public void BackToMainMenu()
    {
        mng.getAudioSource().PlayOneShot(mng.back);
        MenuMng.optionsMenu.SetActive(false);
        MenuMng.mainMenu.SetActive(true);

    }
}
