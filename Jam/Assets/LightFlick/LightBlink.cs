using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlink : MonoBehaviour
{
    [SerializeField] private float randomMaxIntensity;
    [SerializeField] private float maxFrameDuration;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Light light;
    [SerializeField] private Material shader;

    private float intensity;
    private float time;
        float decreaseValue = 0;




    public void Update()
    {
        if (intensity <= 0)
        {
            intensity = Random.Range(0, randomMaxIntensity);
            time = Random.Range(0, maxFrameDuration);
            decreaseValue = intensity / time;
            audioSource.Play(0);
        }


        intensity = intensity - decreaseValue;


        light.intensity = intensity;
        shader.SetColor("_EmissionColor", Color.white * intensity);
    }
}
