using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerShooter : MonoBehaviour  
{
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    public Text ammoCountText;
    public int remainingAmmo = 10;
    public AmmoPooler ammoPooler;

	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown (KeyCode.Space))
        {
            if (remainingAmmo > 0)
            {
                SpawnBullet ();
            }
        }
	}



    void SpawnBullet ()
    {
        //Instantiate (bulletPrefab, spawnPoint.position, transform.rotation);
        ammoPooler.SpawnBullet (spawnPoint);


        ChangeAmmo(-1);
        //remainingAmmo -= 1;
       // ammoCountText.text = remainingAmmo.ToString ();
    }



    public void ChangeAmmo (int amountToAdd)
    {
        remainingAmmo += amountToAdd;
        ammoCountText.text = remainingAmmo.ToString();
    }



    void Start()
    {
        ammoCountText.text = remainingAmmo.ToString();
    }
}
