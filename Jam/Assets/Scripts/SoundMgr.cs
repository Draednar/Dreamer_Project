using FMOD.Studio;
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
    static Dictionary<Transform, EventInstance> parameters = new Dictionary<Transform, EventInstance>();

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

    public static void StartLoopSound(Transform owner)
    {
        parameters[owner].start();
    }

    public static void AddOwner(Transform owner, string name)
    {
        parameters.Add(owner, RuntimeManager.CreateInstance(sounds[name]));
    }

    public static void SetParametersContinue(Transform owner)
    {
        parameters[owner].setParameterByName("Stop", 0f);
    }

    public static void SetParametersStop(Transform owner)
    {
        parameters[owner].setParameterByName("Stop", 1f);
    }

}
