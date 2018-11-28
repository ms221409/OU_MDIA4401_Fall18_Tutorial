using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour 
{
    public float currentHealth = 1000;
    public LayerMask enemyLayer;


    void OnCollisionEnter (Collision col)
    {
        if (col.collider.gameObject.layer != enemyLayer)
            return;

        //
        currentHealth -= 100;
        //Debug.Log (currentHealth);

        if (currentHealth <= 0)
        {
            SceneManager.LoadSceneAsync (0, LoadSceneMode.Single);
        }
    }
}
