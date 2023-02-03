using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameMng : MonoBehaviour
{
    private GameMng gameMng;
    public static int toursBeforeNextEvent;
    private static int storyStepIndex;
    public static int choiceIndex = -1;

    void Start()
    {
        gameMng = this;
        toursBeforeNextEvent = Random.Range(2,5);
    }

    public void tourTaken()
    {
        toursBeforeNextEvent--;
        if (toursBeforeNextEvent == 0)
        {
            switch (storyStepIndex)
            {
                case 0:
                    //Spawn madre entrante nella camera della sorella
                    EventMng.current.SpotMotherTriggerOnEvent.Invoke(); 
                    Debug.Log("First event happened, now second");
                    toursBeforeNextEvent = 1;
                    break;

                case 1:
                    //Apertura camera da letto e stanza della sorella, scelta dell'evento Spawn Padre o Grido Sorella
                    EventMng.current.MasterAndSisterRoom.Invoke();

                    Debug.Log("Second event happened, now third");
                    toursBeforeNextEvent = Random.Range(1, 4);
                    break;

                case 2:
                    EventMng.current.OfficeRoom.Invoke();

                    Debug.Log("Third event happened, now fourth");

                    toursBeforeNextEvent = Random.Range(1, 4);
                    break;

                case 3:
                    //Lo zio inizia a camminare sul pianerottolo (ATTESA INVIO ANIMAZIONE ZIO)
                    EventMng.current.WalkingUncle.Invoke();
                    Debug.Log("Walking Uncle");
                    EventMng.current.DancingLights.Invoke();
                    Debug.Log("Dancing Lights");

                    Debug.Log("Fourth event happened, now fifth");
                    break;
                case 4:
                    
                    break;
            }

            storyStepIndex++;
        }
            
    }
}
