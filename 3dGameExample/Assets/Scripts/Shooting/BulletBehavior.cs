using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletBehavior : MonoBehaviour 
{
    public float bulletSpeed;
    public float bulletLifetime;


	// Use this for initialization
	void OnEnable () 
    {
        Invoke ("Despawn", bulletLifetime);
	}
	


	// Update is called once per frame
	void Update () 
    {
        transform.Translate (Vector3.forward * bulletSpeed * Time.deltaTime);
	}


    void Despawn ()
    {
        //Destroy (gameObject);
        gameObject.SetActive (false);
    }



    void OnTriggerEnter (Collider other)
    {
        CancelInvoke ();
        Despawn ();
    }
}
