using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private Animator myButton = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Cube"))
        {
            myDoor.Play("Door_open", 0, 0.0f);
            myButton.Play("Button_lower", 0, 0.0f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Cube"))
        {
            myDoor.Play("Door_close", 0, 0.0f);
            myButton.Play("Button_rise", 0, 0.0f);
        }
    }
}

