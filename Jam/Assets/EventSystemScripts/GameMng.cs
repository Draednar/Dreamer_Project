using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameMng : MonoBehaviour
{
    private GameMng gameMng;
    public static int toursBeforeNextEvent;
    public static int loopCount;
    private static int storyStepIndex;


    public string choose;

    void Start()
    {
        gameMng = this;
        toursBeforeNextEvent = Random.Range(2, 5);
        toursBeforeNextEvent = 1;
    }




    public void tourTaken()
    {
        toursBeforeNextEvent--;
        loopCount++;
        Debug.Log(loopCount);
        if (toursBeforeNextEvent == 0)
        {
            switch (storyStepIndex)
            {
                case 0:
                    //Spawn madre entrante nella camera della sorella
                    Debug.Log("First event happened, now second");
                    Debug.Log(loopCount);
                    EventMng.current.FirstEvent.Invoke();


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
                    else if (choose == "Master")
                    {
                        Debug.Log("Master Choose");
                        EventMng.current.MasterRoom_Events.Invoke();
                    }
                    toursBeforeNextEvent = Random.Range(1, 3);

                    break;


                case 3:
                    //Uncle
                    Debug.Log("Fourth event happened, now fifth");
                    EventMng.current.PostChoose_Events.Invoke();

                    toursBeforeNextEvent = 1;
                    break;
                case 4:
                    Debug.Log("SisterDeath, now fifth");
                    //EventMng.current.DeSpawn_Uncle.Invoke();

                    EventMng.current.SisterDeath_Event.Invoke();

                    toursBeforeNextEvent = 1;
                    break;
                case 5:
                    EventMng.current.OfficeOpenRandom.Invoke();
                    toursBeforeNextEvent = 1;

                    break;
                case 6:
                    EventMng.current.BedRoomOpenRandom.Invoke();
                    toursBeforeNextEvent = 1;

                    break;
                case 7:
                    EventMng.current.UncleDeath.Invoke();
                    toursBeforeNextEvent = 1;

                    break;

            }

            storyStepIndex++;
        }

    }
}
