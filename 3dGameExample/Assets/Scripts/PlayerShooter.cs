using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerShooter : MonoBehaviour 
{
	public GameObject bulletPrefab;
	public Transform bulletSourceTransform;
	public int ammoRemaining = 10;
	public Text ammoLabel;


	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
			if (ammoRemaining > 0)
				ShootBullet ();
		}
	}


	void ShootBullet ()
	{
		GameObject thisBullet = Instantiate (bulletPrefab, bulletSourceTransform.position, Quaternion.identity);
		thisBullet.transform.localEulerAngles = transform.localEulerAngles;

		ammoRemaining -= 1;
		ammoLabel.text = ammoRemaining.ToString ();
	}


	public void RefillAmmo (int ammoAmount)
	{
		ammoRemaining += 4;
		ammoLabel.text = ammoRemaining.ToString ();
	}
}
