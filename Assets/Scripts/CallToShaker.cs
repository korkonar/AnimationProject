using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallToShaker : MonoBehaviour
{
    
    public CameraShaker cameraShaker;
    public GameObject trigger;
    public float duration, magnitude; 
    // Update is called once per frame
    void Update()
    {
        if (trigger.activeSelf) { 
            StartCoroutine(cameraShaker.Shake(0.15f, 0.3f));
        }
    }
}
