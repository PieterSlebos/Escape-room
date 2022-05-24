using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetector : MonoBehaviour
{
    [SerializeField] private Transform Holder;

    void Update()
    {

        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward));

        if (Vector3.Distance(transform.position, Holder.position) > Vector3.Distance(transform.position, RaycastHit) ) ;
    }
}
