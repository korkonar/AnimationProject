using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpActivator : MonoBehaviour
{
    public GameObject trigger;
    public GameObject toActivate;

    // Update is called once per frame
    void Update()
    {
        if (trigger.activeSelf) toActivate.GetComponent < CameraLerp >().enabled = true;
        else toActivate.GetComponent<CameraLerp>().enabled = false;
    }
}
