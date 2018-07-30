using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float jumpForce;

    private Rigidbody rb;
    private bool allowedToJump;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        allowedToJump = true;
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (allowedToJump)
                rb.AddForce(new Vector3(0, jumpForce, 0));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // vi har lov til å hoppe dersom vi er på bakken
        allowedToJump = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        allowedToJump = false;
    }
}
