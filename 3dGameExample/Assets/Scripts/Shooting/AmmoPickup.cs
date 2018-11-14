using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AmmoPickup : MonoBehaviour 
{
    public int ammoInBox = 5;
    public float rotationSpeed = 50;
    public AudioSource ammoPickupAudioSource;


    void OnTriggerEnter (Collider playerCollider)
    {
        playerCollider.transform.parent.GetComponent<PlayerShooter>().ChangeAmmo (ammoInBox);
        ammoPickupAudioSource.Play();
        Destroy(gameObject);
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
	}
}
