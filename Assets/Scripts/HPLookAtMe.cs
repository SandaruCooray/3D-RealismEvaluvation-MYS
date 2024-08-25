using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPLookAtMe : MonoBehaviour
{


    public Transform cam;



    // Update is called once per frame
    void LateUpdate()
    {
       transform.LookAt(cam);
    }
}
