using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetector : MonoBehaviour
{
    [SerializeField] private Transform Holder;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(Vector3.zero, Vector3.forward * 20);

        //if (Vector3.Distance(transform.position, Holder.position) > Vector3.Distance(transform.position, RaycastHit) ) ;
    }
}
