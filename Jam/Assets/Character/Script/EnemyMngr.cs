using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMngr : MonoBehaviour
{
    private GameObject[] character;
    private Vector3 rotation;

    private Vector3 disablePosition;

    private string staticName;



    void Start()
    {
        character = new GameObject[4];
        for (int i = 0; i < character.Length; i++)
        {
            character[i] = transform.GetChild(i).gameObject;
            disablePosition = transform.position;
        }
    }


    #region nameMethod
    public void ActiveMother()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Mother")
            {
                character[i].SetActive(true);
            }
        }

    }
    public void ActiveFather()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Father")
            {
                character[i].SetActive(true);
            }
        }
    }
    public void ActiveUncle()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Uncle")
            {
                character[i].SetActive(true);
            }
        }
    }
    public void ActiveSister()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Sister")
            {
                character[i].SetActive(true);
            }
        }
    }
    public void DisableMother()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Mother")
            {
                character[i].transform.Rotate(rotation, Space.World);
                character[i].transform.position = disablePosition;
                NotFollow("Mother");
                character[i].SetActive(false);
            }
        }

    }
    public void DisableFather()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Father")
            {
                character[i].transform.Rotate(rotation, Space.World);
                character[i].transform.position = disablePosition;
                NotFollow("Father");
                character[i].SetActive(false);

            }
        }
    }
    public void DisableUncle()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Uncle")
            {
                character[i].transform.Rotate(rotation, Space.World);
                character[i].transform.position = disablePosition;
                NotFollow("Uncle");
                character[i].SetActive(false);

            }
        }
    }
    public void DisableSister()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Sister")
            {
                character[i].transform.Rotate(rotation, Space.World);
                character[i].transform.position = disablePosition;
                NotFollow("Sister");
                character[i].SetActive(false);
            }
        }
    }

    public void SpawnMother()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Mother")
            {
                character[i].GetComponent<EnemyController>().Spawn(PositionMngr.position);
            }
        }
    }
    public void SpawnFather()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Father")
            {
                character[i].GetComponent<EnemyController>().Spawn(PositionMngr.position);
            }
        }
    }
    public void SpawnUncle()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Uncle")
            {
                character[i].GetComponent<EnemyController>().Spawn(PositionMngr.position);
            }
        }

    }
    public void SpawnSister()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Sister")
            {
                character[i].GetComponent<EnemyController>().Spawn(PositionMngr.position);
            }
        }
    }

    public void FollowPlayer_Mother()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Mother")
            {
                character[i].GetComponent<EnemyController>().FollowPlayer();
            }
        }
    }
    public void FollowPlayer_Father()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Father")
            {
                character[i].GetComponent<EnemyController>().FollowPlayer();
            }
        }
    }
    public void FollowPlayer_uncle()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Uncle")
            {
                character[i].GetComponent<EnemyController>().FollowPlayer();
            }
        }
    }
    public void MoveTo_Mother()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Mother")
            {
                character[i].GetComponent<EnemyController>().MoveTo(PositionMngr.position);
            }
        }
    }
    public void MoveTo_Father()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Father")
            {
                character[i].GetComponent<EnemyController>().MoveTo(PositionMngr.position);
            }
        }
    }
    public void MoveTo_Uncle()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Uncle")
            {
                character[i].GetComponent<EnemyController>().MoveTo(PositionMngr.position);
            }
        }
    }
    public void NotFollow(string name)
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == name)
            {
                character[i].GetComponent<EnemyController>().NotFollow();
            }
        }
    }
    public void OpenDoor()
    {

        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Mother")
            {
                character[i].GetComponent<EnemyController>().OpenDoor(new Vector3(0f, -90f, 0));
                rotation = new Vector3(0f, 90f, 0f);
            }
        }
    }

    public void Idle_Mother()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Mother")
            {
                character[i].GetComponent<EnemyController>().Idle();
            }
        }
    }
    public void Idle_Father()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Father")
            {
                character[i].GetComponent<EnemyController>().Idle();
            }
        }
    }
    public void Idle_Uncle()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Uncle")
            {
                character[i].GetComponent<EnemyController>().Idle();
            }
        }
    }

    public void RotateMother()
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i].name == "Mother")
            {
                character[i].transform.Rotate(new Vector3(0f, 90f, 0f), Space.World);
            }
        }
    }

    #endregion





}
