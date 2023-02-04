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
                    toursBeforeNextEvent = Random.Range(1, 3);
                    break;


                case 3:
                    //Uncle
                    Debug.Log("Fourth event happened, now fifth");
                    EventMng.current.PostChoose_Events.Invoke();

                    toursBeforeNextEvent = 1;
                    break;
                case 4:
                    //Uncle
                    Debug.Log("Uncle Follow, now fifth");
                    EventMng.current.Office_UncleFollow_Event.Invoke();

                    toursBeforeNextEvent = 1;
                    break;
                case 5:           
                    Debug.Log("SisterDeath, now fifth");
                    //EventMng.current.DeSpawn_Uncle.Invoke();

                    EventMng.current.SisterDeath_Event.Invoke();

                    toursBeforeNextEvent = 1;
                    break;
            }

            storyStepIndex++;
        }
            
    }
}
