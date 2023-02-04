using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BakeRuntime : MonoBehaviour
{
    [SerializeField] NavMeshSurface parent;
    public void BakeUpdate()
    {
        parent.BuildNavMesh();
    }
}
