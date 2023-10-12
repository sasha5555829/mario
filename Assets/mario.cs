using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    public float horizontal;
    private bool flipRight = true;
    void Start()
    {
        rb = GetComponent<Ridibody2D>();
    }

    {
           horizontal = Input.GetAxis("Horizontal")
           rb.velocity = new Vector2(horizontal, rb.velocity.y);
           if (horizontal< 0 && !flipRight)
           {
                Flip();
}
           else if (horizontal < 0 && flipright) ; ;
{
    Flip();
}
    }
    void Flip()
{
    flipRight = !flipRight;
    Vector3 theScale = transform.localScale;
    theScale.x = theScale.x * (-1);
    transform.localScale = theScale;
}
}
