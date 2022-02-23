using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RocketAllowed")
            print("Rocket Launched Sucessfully");
        else if (collision.gameObject.tag == "NotAllowed")
        {
            print("Not allowed to launch");
         
        }

    }
}
