using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameMng : MonoBehaviour
{
    private GameMng gameMng;
    private static int toursBeforeNextEvent;
    private static int storyStepIndex;

    void Start()
    {
        gameMng = this;
        toursBeforeNextEvent = Random.Range(2,5);
    }

    public void tourTooked()
    {
        toursBeforeNextEvent--;
        if (toursBeforeNextEvent == 0)
        {
            switch (storyStepIndex)
            {
                case 0:
                    //Spawn madre entrante nella camera della sorella
                    EventMng.current.MotherInSisterRoomEvent.Invoke(); 
                    toursBeforeNextEvent = 1;
                    Debug.Log("First event happened, now second");
                    break;
                case 1:
                    //Apertura camera da letto e stanza della sorella
                    EventMng.current.MasterAndSisterRoom.Invoke();
                    toursBeforeNextEvent = Random.Range(1, 4);
                    Debug.Log("Second event happened, now third");
                    break;
                case 2:
                    //Lo zio inizia a camminare sul pianerottolo (ATTESA INVIO ANIMAZIONE ZIO)
                    EventMng.current.WalkingUncle.Invoke();
                    Debug.Log("Third event happened, now fourth");
                    break;
                case 3:
                    EventMng.current.DancingLights.Invoke();
                    break;
            }

            storyStepIndex++;
        }
            
    }
}
