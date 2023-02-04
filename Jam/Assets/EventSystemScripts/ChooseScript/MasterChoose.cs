using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterChoose : MonoBehaviour
{
    [SerializeField] private GameObject gameMngr;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Master Enter");
        gameMngr.GetComponent<GameMng>().choose = "Master";
    }
}
