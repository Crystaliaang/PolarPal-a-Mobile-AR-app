using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PenguinManager : MonoBehaviour
{
    [SerializeField]
    ARRaycastManager m_RaycastManager;
    List<ARRaycastHit> m_Hits = new List<ARRaycastHit>();
    [SerializeField]
    GameObject penguinPrefab;

    Camera arCam;
    GameObject penguinObject;

    // Start is called before the first frame update
    void Start()
    {
        penguinObject = null;
        arCam = GameObject.Find("AR Camera").GetComponent<Camera>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 0)
            return;

        RaycastHit hit;
        Ray ray = arCam.ScreenPointToRay(Input.GetTouch(0).position);
        
        if (m_RaycastManager.Raycast(Input.GetTouch(0).position, m_Hits))
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began && penguinObject == null)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.tag == "Penguin")
                    {
                        penguinObject = hit.collider.gameObject;
                    }
                    else
                    {
                        PenguinPrefab(m_Hits[0].pose.position);
                    }
                }
            }
            else if (Input.GetTouch(0).phase == TouchPhase.Moved && penguinObject != null)
            {
                penguinObject.transform.position = m_Hits[0].pose.position;
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                penguinObject = null;
            }
        }
    }

    private void PenguinPrefab(Vector3 penguinPosition)
        {
            penguinObject = Instantiate(penguinPrefab, penguinPosition, Quaternion.identity);
        }
}