using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public MenuMng mng;

    // Start is called before the first frame update

    private void Start()
    {
        mng= GameObject.Find("MenuMng").GetComponent<MenuMng>();
    }

    public void NewGameButton()
    {
        SceneManager.LoadScene("SampleScene");
        mng.getAudioSource().PlayOneShot(mng.confirm);
    }

    public void OptionsButton()
    {
        MenuMng.mainMenu.SetActive(false);
        MenuMng.optionsMenu.SetActive(true);
        mng.getAudioSource().PlayOneShot(mng.confirm);
    }

    public void CreditButton()
    {
        MenuMng.mainMenu.SetActive(false);
        MenuMng.credits.SetActive(true);
        mng.getAudioSource().PlayOneShot(mng.confirm);
    }
   

}
