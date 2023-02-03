using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UnlockingDoorsObject : MonoBehaviour
{
    [SerializeField] public int doorToOpenIndex;

    //Sostituire OnTriggerEnter col metodo per interagire con l'oggetto 
    private void OnTriggerEnter(Collider other)
    {
        gameObject.active = false;
        EventMng.current.UnlockDoorsItemTaken.Invoke(doorToOpenIndex);
    }




    //void takeItem()
    //{
    //    this.gameObject.SetActive(false);
    //    EventMng.current.UnlockDoorsItemTaken.Invoke(doorToOpenIndex);
    //}
}
