using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AmmoPooler : MonoBehaviour 
{
    [Range (5, 50)]
    public int poolSize = 50;
    public GameObject bulletPrefab;

    [Tooltip ("ARRAY")]
    public GameObject [] bulletPool;


    // Use this for initialization
    void Start () 
    {
        // Create empty array with 50 spaes
        bulletPool = new GameObject [poolSize];

        //
        for (int i = 0; i < poolSize; i++)
        {
            GameObject thisBullet = Instantiate (bulletPrefab);
            bulletPool [i] = thisBullet;
        }

    }



    public void SpawnBullet (Transform spawnTransform)
    {
        bool hasSpawned = false;

        for (int i = 0; i < bulletPool.Length; i++)
        {
            if (!bulletPool [i].activeSelf)
            {
                bulletPool[i].SetActive (true);
                bulletPool[i].transform.position = spawnTransform.position;
                bulletPool[i].transform.rotation = spawnTransform.rotation;
                hasSpawned = true;

                break;
            }
        }


        if (hasSpawned == false)
        {
            Debug.LogError ("ERROR - OUT OF BULLETS!\nPOOL MUST BE BIGGER");
        }

    }
}
