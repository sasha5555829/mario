using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geenGrib : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 JumpAngle = new Vector2(2f, 4);

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(transform.localScale.x * JumpAngle.x, JumpAngle.y);
    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && PlayerPrefs.GetInt("Big") > 0)
        {
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("Big", -1);
        }
    }
}
