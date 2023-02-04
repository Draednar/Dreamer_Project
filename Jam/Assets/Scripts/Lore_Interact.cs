using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lore_Interact : MonoBehaviour , IInteractable
{
    [SerializeField] GameObject lore;

    bool do_once = false;

    public bool AnimationParameter()
    {
        return false;
    }

    public void Interact()
    {
        if (do_once)
        {
            return;
        }

        lore.SetActive(true);

        do_once = true;
    }
}
