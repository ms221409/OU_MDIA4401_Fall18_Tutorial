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
    public AudioSource bulletAudioSource;

	
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
        ammoPooler.SpawnBullet (spawnPoint);
        ChangeAmmo(-1);


        bulletAudioSource.Play();
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
