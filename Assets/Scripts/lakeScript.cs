using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lakeScript : MonoBehaviour
{
    public GameObject lakePrefab;
    bool lakeFlag=false;
    // Update is called once per frame
    void Update()
    {
        if(lakePrefab != null) {
            // if (lakeFlag==false) {
                lakePrefab.transform.LookAt(Camera.main.transform);
                lakePrefab.transform.Rotate(-90.0f, -90.0f, 0.0f, Space.World);
                lakeFlag = true;
            // }
        }
    }
}
