using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using TMPro;


public class v2penguinMovement : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{

    public RectTransform gamePad;
    public float moveSpeed = 0.3f;
    public TMP_Text canMoveTxt;

    bool canMove;
    bool walking;
    GameObject arObject;
    Vector3 move;

    //RaycastHit hit;
    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
    ARRaycastManager aRRaycastManager;

    void Start()
    {
        arObject = GameObject.FindGameObjectWithTag("Penguin2");
        canMove = true;
        aRRaycastManager = FindObjectOfType<ARRaycastManager>();
    }

    void Awake()
    {
        arObject = GameObject.FindGameObjectWithTag("Penguin2");

    }
    void Update()
    {
        arObject = GameObject.FindGameObjectWithTag("Penguin2");
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        transform.localPosition = Vector2.ClampMagnitude(eventData.position - (Vector2)gamePad.position, gamePad.rect.width * 0.5f);

        move = new Vector3(transform.localPosition.x, 0f, transform.localPosition.y).normalized; // no movement in y

        if (!walking)
        {
            walking = true;
            arObject.GetComponent<Animator>().SetBool("Walk", true); // on drag start the walk animation
        }

        //m_RaycastManager.Raycast(touchPosition, s_Hits, TrackableType.PlaneWithinPolygon

        // Perform a raycast to check for collision with a plane
        //if (move && Physics.Raycast(arObject.transform.position, move, out hit, moveSpeed))
        //if (Physics.Raycast(arObject.transform.localPosition, move, out hit, moveSpeed))
            //if (aRRaycastManager.Raycast(screenCenter, hits, TrackableType.PlaneWithinPolygon);
        if (aRRaycastManager.Raycast(move * moveSpeed * Time.deltaTime, hits, TrackableType.Planes))
        {
            arObject.transform.Translate(move * moveSpeed * Time.deltaTime, Space.World);
            canMoveTxt.text = $"  ";
            canMove = true;
        }
        else
        {
            canMoveTxt.text = $"Can not go there!";
            canMove = false;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (canMove)
        {
            // do the movement when touched down
            StartCoroutine(PlayerMovement());
            canMoveTxt.text = $"  ";
        }
        else
        {
            canMoveTxt.text= $"Can not go there!";
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero; // joystick returns to mean pos when not touched
        move = Vector3.zero;
        StopCoroutine(PlayerMovement());
        walking = false;
        arObject.GetComponent<Animator>().SetBool("Walk", false);
        canMoveTxt.text = $"  ";
    }

    IEnumerator PlayerMovement()
    {
        while (true)
        {

            if (move != Vector3.zero)
                arObject.transform.rotation = Quaternion.Slerp
                    (arObject.transform.rotation, Quaternion.LookRotation(move), Time.deltaTime * 5.0f);

            yield return null;
        }
    }
}


