using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger2 : MonoBehaviour
{
    [SerializeField] private Animator Door0 = null;
    [SerializeField] private Animator Button0 = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Cube"))
        {
            Door0.Play("Door0_open", 0, 0.0f);
            Button0.Play("Button0_lower", 0, 0.0f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Cube"))
        {
            Door0.Play("Door0_close", 0, 0.0f);
            Button0.Play("Button0_rise", 0, 0.0f);
        }
    }
}

