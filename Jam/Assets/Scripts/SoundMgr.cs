using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMgr : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<string> key = new List<string>();
    [SerializeField] List<EventReference> value = new List<EventReference>();

    static Dictionary<string, EventReference> sounds = new Dictionary<string, EventReference>();

    void Start()
    {
        for (int i = 0; i < value.Count; i++)
        {
            sounds.Add(key[i], value[i]);
        }
    }

    public static void PlaySound(string name)
    {
        RuntimeManager.PlayOneShot(sounds[name]);
    }
}
