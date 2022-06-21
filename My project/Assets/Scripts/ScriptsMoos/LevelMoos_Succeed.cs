using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMoos_Succeed : MonoBehaviour
{
    public Text text;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            text.text = "CONGRATS, YOU BEAT THE GAME!";
        }
    }
}
