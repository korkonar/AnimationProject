using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeScript : MonoBehaviour
{
    public GameObject handBone;
    public GameObject axe;
    // Start is called before the first frame update
    void Start()
    {
        axe = GameObject.Find("Axe");
        handBone = GameObject.Find("R.Hand");
        axe.transform.SetParent(handBone.transform);
        axe.transform.rotation = new Quaternion(0, 0, 0, 0);
        axe.transform.position = handBone.transform.position + new Vector3(0, 0, 0);
        Vector3 newvec = new Vector3((float)-84.438, (float)104.872, (float)102.619);
        axe.transform.rotation = Quaternion.Euler(newvec);
    }


    // Update is called once per frame
    void Update()
    {
        //axe.transform.position = handBone.transform.position+new Vector3(0, 0, 1);
        //handBone.transform.rotation = Quaternion.Euler(new Vector3(handBone.transform.eulerAngles.x, handBone.transform.eulerAngles.y, handBone.transform.eulerAngles.z));
        //Vector3 eulerHand = new Vector3(handBone.transform.eulerAngles.x, handBone.transform.eulerAngles.y, handBone.transform.eulerAngles.z);
        
        //axe.transform.rotation = Quaternion.Euler(new Vector3(axe.transform.eulerAngles.x, axe.transform.eulerAngles.y, axe.transform.eulerAngles.z) + new Vector3(0, 0, 180));
    }

    public virtual void OnPickup()
    {
        gameObject.SetActive(false);
    }

    
}
