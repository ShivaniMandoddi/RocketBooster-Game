using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMOvement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    [SerializeField]
    private float rocketRotationSpeed;
    private float rocketThrustSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveRocketUp();
    }
    private void MoveRocketUp()
    {
        RocketThrust();
        //RocketRotation();
    }
   

    private void RocketThrust()
    {
        float thrustSpeed = 30f;
        rocketThrustSpeed = thrustSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow))// To move camera in upward direction
        {
            rb.AddRelativeForce(Vector3.up * rocketThrustSpeed);
            print("Going Up");
        }
        
    }
   
}
