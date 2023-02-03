using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class BlinkingLightMng : MonoBehaviour
{

    [SerializeField ] public static List<LightBlink> lights = new List<LightBlink>();

    public static void AddLight(LightBlink light)
    {
        lights.Add(light);      
    }

    public  static void RemoveLight(LightBlink light)
    {
        lights.Remove(light);  
    }

    public void BlinkAll()
    {
        //Effect Blink everywhere
        foreach (LightBlink light in lights)
        {
            light.enabled = true;
        }
    }

    public void BlinkStopAll()
    {
        //Effect Blink everywhere
        foreach (LightBlink light in lights)
        {
            light.enabled = false;
        }
    }

    public void TurnOffAll()
    {
        foreach (LightBlink light in lights)
        {
            light.GetComponent<Light>().enabled = false;
        }
    }

    public void TurnOnAll()
    {
        foreach (LightBlink lightBlink in lights)
        {
            lightBlink.GetComponent<Light>().enabled = true;
            if (!lightBlink.isActiveAndEnabled)
            {
                lightBlink.enabled = true;
                lightBlink.GetComponent<Light>().intensity = lightBlink.lightIntensityBackup;
                lightBlink.enabled = false;
            }
            
        }
    }


}
