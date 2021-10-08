using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Move : MonoBehaviour
{

    public static event Action dead;

    private Rigidbody rb;
    private float movespeed,jumpspeed;
    private float dirX, dirZ, dirY;
    bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        movespeed = 3f;
        jumpspeed = 5f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * movespeed;
        dirZ = Input.GetAxis("Vertical") * movespeed;
        if (Input.GetKeyDown(KeyCode.Space)&&grounded==true)
        {
            rb.AddForce(Vector3.up*jumpspeed, ForceMode.Impulse);
            grounded = false;
        }


    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            ScoreText.Instance.AddScore(1);
            Destroy(collision.collider.gameObject);

            dead?.Invoke();

        }
        if (collision.collider.tag == "Ground")
        {
            grounded = true;
        }

    }
}
