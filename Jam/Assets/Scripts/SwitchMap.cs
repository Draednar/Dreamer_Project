using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMap : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] DisableWall map_1, map_2;
    DisableWall current;

    [SerializeField] Vector3[] positions = new Vector3[4];
    [SerializeField] Vector3[] rotations = new Vector3[4];


    int counter_loop = 0;

    private void Start()
    {
        current = map_1;
        //map_2.transform.gameObject.SetActive(false);
        Player_Movement.change += ChangeMap;
    }

    private void OnDestroy()
    {
        Player_Movement.change -= ChangeMap;
    }

    void ChangeMap()
    {
        if (current == map_1)
        {
            current.ActivateDoor();
            current = map_2;
            current.DisableDoor();
            current.transform.position = positions[counter_loop % 4];
            current.transform.eulerAngles = rotations[counter_loop % 4];
            counter_loop++;
        }

        else if (current == map_2)
        {
            current.ActivateDoor();
            current = map_1;
            current.DisableDoor();
            current.transform.position = positions[counter_loop % 4 ];
            current.transform.eulerAngles = rotations[counter_loop % 4];
            counter_loop++;
        }

    }
    
}
