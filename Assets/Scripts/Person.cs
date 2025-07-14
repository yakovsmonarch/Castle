using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public float Speed;
    public float SpeedRotation;
    
    void Start()
    {
        
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        var offset = new Vector3(h, 0, v);

        transform.Translate(offset * Speed * Time.deltaTime);

        float r = Input.GetAxis("Mouse X");
        transform.Rotate(0, r * SpeedRotation * Time.deltaTime, 0);
    }
}
