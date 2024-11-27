using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class penguinMovement : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{

    public RectTransform gamePad;
    public float moveSpeed = 0.5f;


    GameObject arObject;
    Vector3 move;
    bool dive;
    bool walking;

    void Start()
    {
        arObject = GameObject.FindGameObjectWithTag("Penguin2");
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
        arObject.GetComponent<Animator>().SetBool("dive", false);
        transform.position = eventData.position;
        transform.localPosition = Vector2.ClampMagnitude(eventData.position - (Vector2)gamePad.position, gamePad.rect.width * 0.5f);

        move = new Vector3(transform.localPosition.x, 0f, transform.localPosition.y).normalized; // no movement in y
        
        arObject.transform.Translate(move * moveSpeed * Time.deltaTime, Space.World);

        if (!walking)
        {
            walking = true;
            arObject.GetComponent<Animator>().SetBool("Walk", true); // on drag start the walk animation
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // do the movement when touched down
        StartCoroutine(PlayerMovement());


    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero; // joystick returns to mean pos when not touched
        move = Vector3.zero;
        StopCoroutine(PlayerMovement());
        walking = false;
        arObject.GetComponent<Animator>().SetBool("Walk", false);


    }

    IEnumerator PlayerMovement()
    {
        while (true)
        {
            // arObject.transform.Translate(move * moveSpeed * Time.deltaTime, Space.World);

            // arObject.transform.position += move * moveSpeed * Time.deltaTime; // move the penguin
            if (move != Vector3.zero)
                arObject.transform.rotation = Quaternion.Slerp
                    (arObject.transform.rotation, Quaternion.LookRotation(move), Time.deltaTime * 5.0f);

            yield return null;
        }
    }



}


