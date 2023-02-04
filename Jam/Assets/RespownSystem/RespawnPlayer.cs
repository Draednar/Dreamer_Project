using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{

    public Vector3 position;
    public Quaternion rotation;
    public void SetReSpawnPosition()
    {
        position = transform.position;
        rotation = transform.rotation;
    }

    public void Respawn()
    {
        transform.position = position;
        transform.rotation = rotation;
    }

    public void Death()
    {

    }
}
