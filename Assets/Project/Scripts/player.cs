using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject ball;
    public GameObject playerCamera;

    public float ballDistance = 2f;
    public float ballThrowingForce = 5f;

    private bool holdingBall = true;
    // Start is called before the first frame update
    void Start()
    {
        ball.GetComponent<Rigidbody>().useGravity = false;  
    }

    // Update is called once per frame
    void Update()
    {
        if (holdingBall)
        {
            ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;

            if (Input.GetMouseButtonDown(0))
            {
                holdingBall = false;
                
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
            }

        }
    }
}
