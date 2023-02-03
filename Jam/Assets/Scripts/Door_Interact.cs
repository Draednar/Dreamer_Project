using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Interact : MonoBehaviour , IInteractable
{
    [SerializeField] Animator animator;

    private void Start()
    {
        Player_Movement.reset += ResetDoor;
    }

    private void OnDestroy()
    {
        Player_Movement.reset -= ResetDoor;
    }

    public void Interact()
    {
        animator.SetBool("OpenDoor", true);
    }

    void ResetDoor()
    {
        animator.SetBool("OpenDoor", false);
    }
    
}
