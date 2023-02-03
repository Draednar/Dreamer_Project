using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

[ExecuteInEditMode]
public class DisableWall : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<GameObject> walls = new List<GameObject>();
    [SerializeField] GameObject door;

    public bool disable = false;
    bool was = false;

    private void Update()
    {
        if (disable && !was)
        {
            DisableWalls();
            was = true;
        }

        if (!disable && was)
        {
            ActivateWalls();
            was = false;
        }
    }

    public void DisableWalls()
    {
        for (int i = 0; i < walls.Count; i++)
        {
            walls[i].SetActive(false);
        }
    }

    public void ActivateWalls()
    {
        for (int i = 0; i < walls.Count; i++)
        {
            walls[i].SetActive(true);
        }
    }

    public void DisableDoor()
    {
        door.SetActive(false);
    }

    public void ActivateDoor()
    {
        door.SetActive(true);
    }
}
