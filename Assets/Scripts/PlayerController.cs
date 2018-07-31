using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float jumpForce;
    public float maxSpeed;

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

        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

        rb.AddForce(movement * speed);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // allow jumping if we are on the 'ground'
            if (gameObject.transform.position.y >= 0.48f && gameObject.transform.position.y <= 0.54f)
                rb.AddForce(new Vector3(0, jumpForce, 0));
        }
    }
}
