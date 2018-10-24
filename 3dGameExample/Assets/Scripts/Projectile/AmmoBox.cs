using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AmmoBox : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		other.transform.parent.GetComponent <PlayerShooter> ().RefillAmmo (4);
		Destroy (transform.parent.gameObject);
	}
}
