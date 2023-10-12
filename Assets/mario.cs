using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    public float horizontal;
    private bool flip = true;

    void Player.Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if (horizontal > 0 && !flip)
        {
            void Player.Flip();
        }
        else if (horizontal < 0 && flip)
        {
            void Player.Flip();
        }
    }


    void Player.Flip()
    {
        flip = !flip;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}