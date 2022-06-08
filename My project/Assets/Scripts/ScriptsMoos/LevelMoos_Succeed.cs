using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMoos_Succeed : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}
