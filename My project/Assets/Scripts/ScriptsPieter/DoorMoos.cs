using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMoos : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closedTrigger = false;

    private CheckScript checkScript;
    private GameControler gameControler;

    private void Start()
    {
        gameControler = GameObject.FindObjectOfType<GameControler>();
        checkScript = GameObject.FindObjectOfType<CheckScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                Debug.Log(checkScript.LevelIdeSucceed);
                if (gameControler.levelBallsSucceed == true && checkScript.LevelIdeSucceed == true)
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