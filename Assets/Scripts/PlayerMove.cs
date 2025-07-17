using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float RotationSensitivity;
    public Transform TransformCamera;
    public Rigidbody Rigidbody;
    public float Speed;
    public float JampForce;

    private float _xRotation;
    private bool _grounded;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            _xRotation -= Input.GetAxis("Mouse Y") * RotationSensitivity;
            _xRotation = Mathf.Clamp(_xRotation, -60, 60);
            TransformCamera.localEulerAngles = new Vector3(_xRotation, 0f, 0f);

            transform.Rotate(0, Input.GetAxis("Mouse X") * RotationSensitivity, 0);
        }
        if (_grounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Rigidbody.AddForce(0f, JampForce, 0f, ForceMode.Impulse);
            }
        }
    }

    void FixedUpdate()
    {
        Vector3 inputVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 speedVector = inputVector * Speed;
        Vector3 speedVectorRelative = transform.TransformVector(speedVector);

        Rigidbody.velocity = new Vector3(speedVectorRelative.x, Rigidbody.velocity.y, speedVectorRelative.z);
    }

    void OnCollisionStay(Collision collision)
    {
        Vector3 normal = collision.contacts[0].normal;
        float dot = Vector3.Dot(normal, transform.up);

        if(dot >= 0.5f) _grounded = true;
    }

    void OnCollisionExit(Collision collision)
    {
        _grounded = false;  
    }

}
