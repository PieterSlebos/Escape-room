using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger3 : MonoBehaviour
{
    [SerializeField] private Animator Door2 = null;
    [SerializeField] private Animator Button2 = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Cube"))
        {
            Door2.Play("Door2_open", 0, 0.0f);
            Button2.Play("Button2_lower", 0, 0.0f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Cube"))
        {
            Door2.Play("Door2_close", 0, 0.0f);
            Button2.Play("Button2_rise", 0, 0.0f);
        }
    }
}

