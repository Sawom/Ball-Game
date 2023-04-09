//Applying Force
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class move : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public Rigidbody rd;

//     void Start()
//     {
//         //rd = GetComponent<Rigidbody>();
//         rd.AddForce(5000 * Time.deltaTime, 0, 0);
//     }

//     // Update is called once per frame
//     void Update()
//     {
       
//     }
// }

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class move : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public Rigidbody rd;

//     void Start()
//     {
//         rd = GetComponent<Rigidbody>();
//         //rd.useGravity = false;
//         //rd.AddForce(5000 * Time.deltaTime, 0, 0);
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
//         {
//             rd.AddForce(0, 0, 500 * Time.deltaTime);

//         }
//         if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
//         {
//             rd.AddForce(500 * Time.deltaTime, 0, 0);

//         }
//         if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
//         {
//             rd.AddForce(0, 0, -500 * Time.deltaTime);

//         }
//         if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
//         {
//             rd.AddForce(-500 * Time.deltaTime, 0, 0);

//         }

//     }
// }

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;


// public class move : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public Rigidbody rd;
//     public bool canJump;

//     void Start()
//     {
//         rd = GetComponent<Rigidbody>();
//         //rd.useGravity = false;
//         //rd.AddForce(5000 * Time.deltaTime, 0, 0);
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
//         {
//             rd.AddForce(0, 0, 500 * Time.deltaTime);

//         }
//         if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
//         {
//             rd.AddForce(500 * Time.deltaTime, 0, 0);

//         }
//         if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
//         {
//             rd.AddForce(0, 0, -500 * Time.deltaTime);

//         }
//         if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
//         {
//             rd.AddForce(-500 * Time.deltaTime, 0, 0);

//         }

//         if (Input.GetKey(KeyCode.Space) && canJump)
//         {

//             rd.AddForce(0, 150 * Time.deltaTime, 0, ForceMode.VelocityChange);

//         }


//     }


//     private void OnCollisionEnter(Collision collision)
//     {
//         Debug.Log(collision.collider.name);
//         if (collision.collider.tag == "Ground")
//         {
//             canJump = true;

//         }

//     }

//     private void OnCollisionExit(Collision collision)
//     {
//         Debug.Log(collision.collider.name);
//         if (collision.collider.tag == "Ground")
//         {
//             canJump = false;

//         }

//     }

// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rd;
    public bool canJump = true;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
        //rd.useGravity = false;
        //rd.AddForce(5000 * Time.deltaTime, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
        {
            rd.AddForce(0, 0, 500 * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            rd.AddForce(500 * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            rd.AddForce(0, 0, -500 * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
            rd.AddForce(-500 * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.Space) && canJump) {

            rd.AddForce(0, 250 * Time.deltaTime,0, ForceMode.VelocityChange);

        }


       

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        if (collision.collider.tag == "Ground")
        {
            canJump = true;

        }

        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("Obstacle hit");
            //GetComponent<Move>().enabled = false;
            ScoreText.scoreDeduct();
        }
            
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log(collision.collider.name);
        if (collision.collider.tag == "Ground")
        {
            canJump = false;

        }

    }
}