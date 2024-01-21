using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luckyBlock : MonoBehaviour
{
    public Transform objects;


    private void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "head")
        {
            gameObject.SetActive(false);
            Instantiate(objects, transform.position, transform.rotation);
        }
    }
}
