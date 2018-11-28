using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHealth : MonoBehaviour 
{
    public float remainingHealth = 100;


    void OnTriggerEnter (Collider other) 
    {
        //Debug.Log(other.gameObject.name);
        remainingHealth -= 50;
        //Debug.Log (remainingHealth);

        //
        if (remainingHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
