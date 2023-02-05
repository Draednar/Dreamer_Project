using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UncleSpawnRinghiera : MonoBehaviour
{

    [SerializeField] public GameObject uncle;
    [SerializeField] public GameObject copy;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Uncle Spawn");

        uncle.SetActive(true);
        uncle.GetComponent<Animator>().SetBool("Ringhiera", true);

        gameObject.SetActive(false);
        copy.SetActive(false);
    }
}
