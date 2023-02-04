using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Interact : MonoBehaviour, IInteractable
{
    [SerializeField] Animator animator;

    [SerializeField] bool no_close_sound;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

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

    public void OpenSound()
    {
        SoundMgr.PlaySound("Open");
        Debug.Log("open sound started");
    }

    public void CloseSound()
    {
        if (no_close_sound)
        {
            return;
        }

        SoundMgr.PlaySound("Close");
        Debug.Log("close sound started");
    }

    void ResetDoor()
    {
        animator.SetBool("OpenDoor", false);
    }

    public bool AnimationParameter()
    {
        return animator.GetBool("OpenDoor");
    }
}
