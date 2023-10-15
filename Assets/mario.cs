using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class mario : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    public float horizontal;
    private bool flip = true;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
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
    }

}