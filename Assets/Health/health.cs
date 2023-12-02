using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float _value)
    {
        currentHealth = Math.Clamp(currentHealth - _value, 0, startingHealth);

        if (currentHealth > 0)
        {
            //b
        }
        else
        {
            //a
        }
    }

    public void addHealth(float _value)
    {
        currentHealth = Math.Clamp(currentHealth + _value, 0, startingHealth);
    }
}  
