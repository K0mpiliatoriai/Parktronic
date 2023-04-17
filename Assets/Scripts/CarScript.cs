using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    float driftFactor = 0.05f;
    public float  accelerationFactor = 5.0f;
    public float turnFactor = 0.3f;
    public float maxSpeed = 10f;
    public GameObject brakes;

    float accelerationInput = 0, steeringInput = 0, rotationAngle = 0, velocityVsUp = 0, velocity=0;

    Vector2 inputVector = Vector2.zero;
    void Awake()
    {
        myRigidBody=GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        steeringInput = inputVector.x;
        accelerationInput = inputVector.y;
    }

    // Update is called once per frame
    void Update()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");
        SetInputVector(inputVector);

    }
    void FixedUpdate()
    {
        ApplyEngineForce();
        KillOrthogonalVelocity();
        ApplySteering();
    }
    void ApplyEngineForce()
    {
        //calculate speed
        velocityVsUp = Vector2.Dot(transform.up, myRigidBody.velocity);

        //limit the speed
        if(velocityVsUp > maxSpeed && accelerationInput > 0)
        {
            return;
        }

        //same in reverse
        if(velocityVsUp < -maxSpeed *0.5f && accelerationInput < 0)
        {
            brakes.SetActive(true);
            return;
        }
        else
        {
            brakes.SetActive(false);
        }
        if (accelerationInput < 0)
        {
            brakes.SetActive(true);
        }


        //other directions
        if(myRigidBody.velocity.sqrMagnitude > maxSpeed*maxSpeed && accelerationInput>0)
        {
            return;
        }

        if(accelerationInput == 0)
        {
            myRigidBody.drag = Mathf.Lerp(myRigidBody.drag, 3.0f, Time.fixedDeltaTime * 3);
        }
        else
        {
            myRigidBody.drag = 0;
        }

        velocity = Vector2.Dot(myRigidBody.velocity, transform.up);
        if (velocity > 0 & accelerationInput < 0)
        {
            //increase braking power when going forward
            Vector2 engineForceVector = transform.up * accelerationInput * accelerationFactor * 4;
            myRigidBody.AddForce(engineForceVector, ForceMode2D.Force);
        }
        else if (velocity < 0 & accelerationInput > 0)
        {
            //Increase braking power when going reverse
            Vector2 engineForceVector = transform.up * accelerationInput * accelerationFactor * 3;
            myRigidBody.AddForce(engineForceVector, ForceMode2D.Force);
        }
        else
        {
            //force for the engine
            Vector2 engineForceVector = transform.up * accelerationInput * accelerationFactor;

            //apply force and push car forward
            myRigidBody.AddForce(engineForceVector, ForceMode2D.Force);
        }
    }

    void ApplySteering()
    {
        //limit turning ability when stationary
        float minSpeedBeforeTurning = (myRigidBody.velocity.magnitude / 15);
        minSpeedBeforeTurning = Mathf.Clamp01(minSpeedBeforeTurning);

        //inverting steering if going in reverse
        velocity = Vector2.Dot(myRigidBody.velocity, transform.up);
        rotationAngle = myRigidBody.rotation;

        if (velocity > 0)
        {
            //updating rotation based on input
            rotationAngle -= steeringInput * turnFactor * minSpeedBeforeTurning;

            //apply steering
            myRigidBody.MoveRotation(rotationAngle);
        }
        else if(velocity < 0)
        {   
            //updating rotation based on input
            rotationAngle -= -steeringInput * turnFactor * minSpeedBeforeTurning;

            //apply steering
            myRigidBody.MoveRotation(rotationAngle);
        }
    }

    void KillOrthogonalVelocity()
    {
        Vector2 forwardVelocity = transform.up * Vector2.Dot(myRigidBody.velocity, transform.up);
        Vector2 rightVelocity = transform.right * Vector2.Dot(myRigidBody.velocity, transform.right);

        myRigidBody.velocity = forwardVelocity + rightVelocity * driftFactor;
    }

    void SetInputVector(Vector2 inputVector)
    {
        steeringInput = inputVector.x;
        accelerationInput= inputVector.y;
    }
}
