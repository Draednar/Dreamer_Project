using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoverMouse : MonoBehaviour
{
    private Color defaultColor = new Color();

    private void Awake()
    {
        TextMeshPro defaultColo = GetComponent<TextMeshPro>();
        if (defaultColo != null) Debug.Log("Textmesh present");
       
        //textMesh.color = Color.red;
    }

    private void OnMouseEnter()
    {
        Debug.Log("Mouse arrived");
        //textMesh.text = "- New Game -";
        //textMesh.faceColor = Color.white;
    }

}
