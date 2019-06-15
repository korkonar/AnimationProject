using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject cameraToMove;
    public GameObject pivot;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (pivot.activeSelf) {
            cameraToMove.transform.position = pivot.transform.position;
            cameraToMove.transform.rotation = pivot.transform.rotation;
        }
    }
}
