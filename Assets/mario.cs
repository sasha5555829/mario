using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Tracing;
using System.Security.Cryptography;
using UnityEngine;

public class mario: MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    public float horizontal;
    private bool flip = true;
    public Animator animator;
    public int JumpForce = 10;
    public bool onGround;
    public LayerMask Ground;
    public Transform GroundCheck;
    private float GroundCheckRadius;

    private Vector3 RespawnPoint;
    public GameObject deadZone;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        GroundCheckRadius = GroundCheck.GetComponent<CircleCollider2D>().radius;
        RespawnPoint = transform.position;
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        animator.SetFloat("moveX",Math.Abs(horizontal));
        if ((horizontal > 0 && !flip) || (horizontal < 0 && flip))
        {
            transform.localScale *= new Vector2(-1, 1);
            flip = !flip;
        }
        Jump();
        CheckingGround();

        deadZone.transform.position = new Vector2(transform.position.x, deadZone.transform.position.y); 
    }

    void Jump()
    {
        if (onGround && Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
        }
    }

    void CheckingGround() 
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, Ground);
        animator.SetFloat("moveY", Mathf.Abs(rb.velocity.y));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "deadzone")
        {
            transform.position = RespawnPoint;
        }
        else if (collision.tag == "checkpoint")
        {
            RespawnPoint = transform.position;
        }
    }
}