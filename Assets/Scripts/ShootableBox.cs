using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class ShootableBox : MonoBehaviour
{
    public int currentHealth = 5;
    public void Damage(int damageAmount)
    {
       currentHealth -= damageAmount;
       if(currentHealth <= 0)
       {
        gameObject.SetActive (false);
       }
    }
}
