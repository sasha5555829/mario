using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{

    public Transform kusok;
    

    private void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "head" && PlayerPrefs.GetInt("Big") == 1)
        {
            gameObject.SetActive(false);
            Instantiate(kusok, transform.position, transform.rotation);
        }
    }
}
