using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Animator animator;


    private bool isStalker;
    private bool openDoor;
    private bool idle;


    public void Update()
    {
        if (gameObject.name == "Sister")
        {
        }
        else
        {
            if (isStalker)
            {
                AnimatorSetFalse("Idle", "OpenDoor");
                animator.SetBool("Walk", true);
                NavMeshMngr.Update();
            }
            else if (openDoor)
            {
                AnimatorSetFalse("Idle", "Walk");
                animator.SetBool("OpenDoor", true);
            }
            else if (idle)
            {
                AnimatorSetFalse("OpenDoor", "Walk");
                animator.SetBool("Idle", true);
            }
        }


    }


    public void FollowPlayer()
    {
        NavMeshMngr.Follow(gameObject, GameObject.FindGameObjectWithTag("Player"));
        isStalker = true;
    }
    public void FollowPlayer(float dist)
    {
        NavMeshMngr.Follow(gameObject, GameObject.FindGameObjectWithTag("Player"), dist);
        isStalker = true;
    }
    public void MoveTo(Vector3 target)
    {
        NavMeshMngr.Follow(gameObject, target);
        isStalker = true;
    }
    public void NotFollow()
    {
        NavMeshMngr.NotFollow();
        isStalker = false;
    }

    public void Spawn(Vector3 positionSpawn)
    {
        transform.position = positionSpawn;
    }

    public void OpenDoor(Vector3 rotation)
    {
        transform.Rotate(rotation, Space.World);
    }

    public void Idle()
    {
        idle = true;
    }


    private void AnimatorSetFalse(string name1, string name2)
    {
        animator.SetBool(name1, false);
        animator.SetBool(name2, false);
    }
}
