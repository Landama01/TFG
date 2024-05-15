using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRedBullet : MonoBehaviour
{
    public GameObject redBullet;
    public Transform shootSpot;
    public int bullets = 3;
    public int maxBullets = 3;

    public float reloadingTime = 0f;
    public float maxReloadingTime = 3f;   

    bool canShoot = false;
    float checkShootInterval = 0.2f;
    float nextCheckShootTime;
    int shotChance;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextCheckShootTime)
        {
            if (canShoot)
            {
                shotChance = Random.Range(0, 5);
            }

            nextCheckShootTime = Time.time + checkShootInterval;
        }

       

        if (canShoot && shotChance == 1 && bullets > 0)
        {
            Instantiate(redBullet, shootSpot.position, shootSpot.rotation);
            bullets--;
            shotChance = 0;
        }

        if (bullets < maxBullets)
        {
            reloadingTime += Time.deltaTime;
        }

        if (reloadingTime >= maxReloadingTime)
        {
            bullets++;
            reloadingTime = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BlueTank"))
        {
            canShoot = true;
        }
    }
}

