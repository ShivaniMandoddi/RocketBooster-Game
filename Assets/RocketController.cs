using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RocketController : MonoBehaviour
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
        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.constraints=RigidbodyConstraints.FreezePosition;
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.constraints = ~RigidbodyConstraints.FreezePosition;

        }*/
    }

    private void MoveRocketUp()
    {
        RocketThrust();
        RocketRotation();
    }

    private void RocketRotation()
    {
        //rb.freezeRotation = false;
        float speed = 100.0f;

        if (Input.GetKey(KeyCode.LeftArrow)) // To move rocket in right direction
        {
            rocketRotationSpeed =speed* Time.deltaTime;
        
            transform.Rotate(Vector3.forward* rocketRotationSpeed);
            print("Forward Rotation");
        }
        if (Input.GetKey(KeyCode.RightArrow)) // To move rocket in left direction
        {
            rocketRotationSpeed = speed* Time.deltaTime;
            transform.Rotate(Vector3.back*rocketRotationSpeed);
            print("Left Rotation");
        }
    }

    private void RocketThrust()
    {
        float thrustSpeed = 100f;
        rocketThrustSpeed = thrustSpeed* Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow))// To move rocket in upward direction
        {

            rb.AddRelativeForce(Vector3.up*rocketThrustSpeed);
            print("Going Up");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "NotAllowed")
        {
            print("Not allowed to touch");
            string sceneName = SceneManager.GetActiveScene().name;
           
            SceneManager.LoadScene(sceneName);
        }
        }
    
    // Assessment: I want to use up,left and right arrow to control the movement of rocket 
}
