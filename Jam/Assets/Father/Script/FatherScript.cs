using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherScript : MonoBehaviour
{
    private bool isStalker;

    public void Update()
    {
        if (isStalker)
        {
            NavMeshMngr.Update();
        }
    }


    public void Follow()
    {
        NavMeshMngr.Follow(gameObject, GameObject.FindGameObjectWithTag("Player"));
        isStalker = true;
    }
    public void Follow(float dist)
    {
        NavMeshMngr.Follow(gameObject, GameObject.FindGameObjectWithTag("Player"), dist);
        isStalker = true;
    }

    public void Spawn(Vector3 positionSpawn)
    {
        transform.position = positionSpawn;
    }
}
