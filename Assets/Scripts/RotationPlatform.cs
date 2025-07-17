using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlatform : MonoBehaviour
{
    public Rigidbody Rigidbody;

    void FixedUpdate()
    {
        Vector3 vectorEuler = transform.eulerAngles + new Vector3(0f, 1f, 0f);
        Rigidbody.MoveRotation(Quaternion.Euler(vectorEuler));    
    }
}
