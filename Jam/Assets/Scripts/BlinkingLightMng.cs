using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class BlinkingLightMng : MonoBehaviour
{

    [SerializeField ] public List<LightBlink> lights;

    private void Awake()
    {
        lights = new List<LightBlink>();
    }

    public void AddLight()
    {
        this.lights.Add(new LightBlink());
    }

    public  void RemoveLight()
    {
        lights.Remove(new LightBlink());
    }

    public void BlinkAll()
    {
        //Effect Blink everywhere
        Debug.Log("BlinkAll() ancora non implementato");
    }


}
