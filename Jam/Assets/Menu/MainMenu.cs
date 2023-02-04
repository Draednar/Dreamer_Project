using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private GameObject mainMenu;
    private GameObject newGame;
    private GameObject optionsMenu;
    private GameObject Credits;

    public AudioSource buttonSound;


    // Start is called before the first frame update
    void Start()
    {
        mainMenu = GameObject.Find("MainMenu");
   }

    public void newGameButton()
    {
        //buttonSound.Play();
        SceneManager.LoadScene("SampleScene");
    }

   
}
