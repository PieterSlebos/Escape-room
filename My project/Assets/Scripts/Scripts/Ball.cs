using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(SetDespawn());
    }

    private IEnumerator SetDespawn()
    {
        yield return new WaitForSeconds(15f);
        GameObject.Destroy(this.gameObject);
    }
}
