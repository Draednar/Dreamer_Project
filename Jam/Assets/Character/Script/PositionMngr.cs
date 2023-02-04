using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMngr : MonoBehaviour
{
    public static Vector3 position;
    public static Vector3 rotation;

    public static void SetSpawnPosition(Transform Position)
    {
        position = Position.position;
    }
    public static void SetTargetPosition(Transform Position)
    {
        position = Position.position;
    }
    public static void SetRotation(Vector3 Rotation)
    {
        rotation = Rotation;
    }
}
