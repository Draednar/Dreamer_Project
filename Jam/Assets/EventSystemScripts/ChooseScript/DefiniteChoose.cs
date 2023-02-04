using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefiniteChoose : MonoBehaviour
{
    public string choose;


    public void SetChoose(string Choose)
    {
        Debug.Log(Choose);
        choose = Choose;
    }
}
