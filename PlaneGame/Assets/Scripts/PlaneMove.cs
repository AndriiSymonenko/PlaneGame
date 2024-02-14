using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float ForceValue;
    public float TorqueValue;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Rigidbody.AddForce(transform.forward, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Rigidbody.AddForce(-transform.forward, ForceMode.VelocityChange);
        }

        float vertical = Input.GetAxis("Vertical");
        Rigidbody.AddTorque(-transform.right * TorqueValue * vertical, ForceMode.VelocityChange);
    }
}
