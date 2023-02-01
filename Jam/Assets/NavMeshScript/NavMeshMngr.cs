using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMngr : MonoBehaviour
{

    static private Transform target;

    static private Transform stalker;
    static private NavMeshAgent navMeshAgentStalker;

    static private float targetDistance;
    static private float dist;

    static private bool isFollower;
    static private bool followLastPosition;

    public static void Update()
    {
        targetDistance = Vector3.Distance(target.position, stalker.position);

        if (isFollower)
        {
            if (dist > 0)//Check if the distance is given
            {
                if (targetDistance <= dist)
                {
                    navMeshAgentStalker.destination = target.position;
                }
                else
                {
                    if (!followLastPosition)
                    {
                        navMeshAgentStalker.destination = stalker.position;
                        //Reset the destination to stalker position
                    }
                }
            }
            else
            {
                navMeshAgentStalker.destination = target.position;
            }
        }
    }




    static public void Follow(GameObject Obj, GameObject Target, float Dist = 0, bool FollowLastPosition = false)
    {
        target = Target.GetComponent<Transform>();
        stalker = Obj.transform;
        navMeshAgentStalker = Obj.GetComponent<NavMeshAgent>();
        dist = Dist;
        followLastPosition = FollowLastPosition;

        isFollower = true;
    }
    static public void NotFollow()
    {
        isFollower = false;
        navMeshAgentStalker.destination = stalker.position;
        //Reset the destination to stalker position
    }


}
