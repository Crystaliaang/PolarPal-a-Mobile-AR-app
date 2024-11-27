using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PenguinTriggerCollider : MonoBehaviour
{

    public GameObject button;


    void Start()
    { button.GetComponent<Button>().interactable = false; }

        void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lake"))
        {
            button.GetComponent<Button>().interactable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Lake"))
        {
            button.GetComponent<Button>().interactable = false;
        }
    }
}