using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMoos_Succeed : MonoBehaviour
{
    public GameObject screen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var x = Instantiate(screen, new Vector3(0, 0, 0), Quaternion.identity);
            //gameObject.SetActive(false);
        }
    }
}
