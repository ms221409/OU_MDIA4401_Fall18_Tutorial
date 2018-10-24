using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour 
{
	public float speed = 20;
	public float lifetime = 2;


	//
	//
	void Update ()
	{
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
	}


	void DespawnBullet ()
	{
		Destroy (gameObject);
	}


	//
	//
	void Start ()
	{
		Invoke ("DespawnBullet", lifetime);
	}


	#region Physics

	//
	//
	void OnTriggerEnter (Collider other)
	{
		
	}

	#endregion
}
