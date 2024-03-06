using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public int Freanar = 1000;
    public WheelCollider Rueda1;
    public WheelCollider Rueda2;
    public WheelCollider Rueda3;
    public WheelCollider Rueda4;
    public Transform Llantas1;
    public Transform Llantas2;
    public int Velocity = 1000;

    void Update()
    {
        Llantas1.localEulerAngles = new Vector3(0, Rueda3.steerAngle, 0);
        Llantas2.localEulerAngles = new Vector3(0, Rueda4.steerAngle, 0);
    }

    void FixedUpdate()
    {
        Rueda1.motorTorque = Velocity * Input.GetAxis("Vertical");
        Rueda2.motorTorque = Velocity * Input.GetAxis("Vertical");
        Rueda3.steerAngle = -40 * Input.GetAxis("Horizontal"); //rotacion
        Rueda4.steerAngle = -40 * Input.GetAxis("Horizontal");

        if (Input.GetAxis("Vertical") == 0)
        {
            Rueda1.brakeTorque = Freanar;
            Rueda2.brakeTorque = Freanar;
        }
        else
        {
            Rueda1.brakeTorque = 0;
            Rueda2.brakeTorque = 0;
        }
    }
}
