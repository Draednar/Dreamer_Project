using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameMng : MonoBehaviour
{
    private GameMng gameMng;
    public static int toursBeforeNextEvent;
    private static int storyStepIndex;


    public string choose;

    void Start()
    {
        gameMng = this;
        toursBeforeNextEvent = Random.Range(2,5);
    }

    public void StartWaiting(int seconds)
    {
        Wait(seconds);
    }

    public IEnumerator Wait(int seconds)
    {
        yield return new WaitForSeconds(seconds);
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
                    EventMng.current.FirstEvent.Invoke(); 
                    Debug.Log("First event happened, now second");
                    toursBeforeNextEvent = 1;
                    break;

                case 1:
                    //Apertura camera da letto e stanza della sorella, scelta dell'evento Spawn Padre o Grido Sorella
                    EventMng.current.MasterAndSisterRoom.Invoke();

                    Debug.Log("Second event happened, now third");
                    toursBeforeNextEvent = 1;
                    break;

                case 2:
                    Debug.Log("Third event happened, now fourth");
                    if (choose == "Sister")
                    {
                        Debug.Log("Sister Choose");
                        EventMng.current.SisterRoom_Events.Invoke();
                    }
                    else if(choose == "Master")
                    {
                        Debug.Log("Master Choose");
                        EventMng.current.MasterRoom_Events.Invoke();
                    }
                    toursBeforeNextEvent = 1;
                    break;


                //case 2:
                //    EventMng.current.OfficeRoom.Invoke();

                //    Debug.Log("Third event happened, now fourth");

                //    toursBeforeNextEvent = Random.Range(1, 4);
                //    break;

                case 3:
                    //Lo zio inizia a camminare sul pianerottolo (ATTESA INVIO ANIMAZIONE ZIO)
                    EventMng.current.WalkingUncle.Invoke();
                    Debug.Log("Walking Uncle");
                    EventMng.current.DancingLights.Invoke();
                    Debug.Log("Dancing Lights");

                    Debug.Log("Fourth event happened, now fifth");

                    toursBeforeNextEvent = 1;
                    break;
                case 4:
                    EventMng.current.SisterDeath.Invoke();
                    Debug.Log("Sister Death happened, now fifth");
                    break;
            }

            storyStepIndex++;
        }
            
    }
}
