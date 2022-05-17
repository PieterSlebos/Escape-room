using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DTCMoos : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closedTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Cube"))
        {
            if (openTrigger)
            {
                myDoor.Play("Door_open", 0, 0.0f);
                gameObject.SetActive(false);
            }

            else if (closedTrigger)
            {
                myDoor.Play("Door_close", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}

