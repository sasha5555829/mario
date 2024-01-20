using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kusok : MonoBehaviour
{
    [SerializeField] private float oboroti;

    private void Start()
    {
        Destroy(transform.parent.gameObject, 2f);
    }

    private void Update()
    {
        transform.Rotate(0, 0, 180 * oboroti * Time.deltaTime);
    }
}
