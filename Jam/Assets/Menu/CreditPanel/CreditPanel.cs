using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditPanel : MonoBehaviour
{
    public MenuMng mng;

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
}
