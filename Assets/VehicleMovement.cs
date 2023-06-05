using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovement : MonoBehaviour
{
    public float speed;

    [Header("Drive Settings")]
    public float driveForce = 17f;
    public float slowingVelFactor = .99f;
    public float brakingVelFactor = .95f;
    public float angleOfRoll = 30f:

    [Header("Hover Settings")]
    public float hoverHeight = 1.5f
    public float maxGroundDist = 5f;
    public float hoverForce = 300f;
    public LayerMask whatIsGround
    public PIDController hoverPID;

    [Header("Physics Settings")]
    public float terminalVelocity = 100f;
    public float hoverGravity = 20f;
    public float fallGravity = 80f;

    RigidBody rigidBody;
    PlayerInputs input;
    float drag;
    bool isOnGround

    void Start()

    {

        rigidBody = GetComponent<RigidBody>():
        input = GetComponent<PlayerInput>():

        drag = driveForce / terminalVelocity

    }
        
        speed = Vector3.Dot(rigidBody.velocity, transform.forward);

        CalculatHover();
        CalculatePropulsion():

    {

    void CalculatHover()
    }
        
        Vector3 groundNormal;

        Ray ray = new Ray(transform.position, -transform.up);

        RaycastHit hitInfo

        isOnGround = Physic.Raycast(ray, out hitInfo, maxGroundDist, whatIsGround)

        if (isOnGround)
    {

        float height = hitInfo.distance;

        groundNormal = hitInfo.normal.normalized;

        float forcePercent = hoverPID.Seek(hoverHeight, height);


        Vector3 gravit y= -groundNormal * hoverGravity * height;

        rigidBody.AddForce(force, ForceMode.Acceleration);
        rigidBody

    }



    {



    }


}
