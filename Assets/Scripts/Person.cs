using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public float Speed;
    public float SpeedRotation;

    private float _boost = 3;
    
    void Start()
    {
        
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        var offset = new Vector3(h, 0, v);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(offset * Speed * _boost * Time.deltaTime);
        }
        else
        {
            transform.Translate(offset * Speed * Time.deltaTime);
        }

        float offsetR = Input.GetAxis("Mouse X");
        transform.Rotate(0, offsetR * SpeedRotation * Time.deltaTime, 0);
    }
}
