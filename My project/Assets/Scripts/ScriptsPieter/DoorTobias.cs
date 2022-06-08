using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTobias : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closedTrigger = false;

    private CollissionCoin collissionCoin;

    private void Start()
    {
        collissionCoin = GameObject.FindObjectOfType<CollissionCoin>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                if (collissionCoin.levelBallsSucceed == true)
                {
                    myDoor.Play("DoorOpen", 0, 0.0f);
                    gameObject.SetActive(false);

                }
            }

            else if (closedTrigger)
            {
                myDoor.Play("DoorClose", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
