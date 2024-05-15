using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBlueBullet : MonoBehaviour
{
    public GameObject blueBullet;
    public Transform shootSpot;
    public int bullets = 3;
    public int maxBullets = 3;

    public float reloadingTime = 0f;
    public float maxReloadingTime = 3f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && bullets > 0)
        {
            Instantiate(blueBullet, shootSpot.position, shootSpot.rotation);
            bullets--;
        }

        if(bullets < maxBullets)
        {
            reloadingTime += Time.deltaTime;
        }

        if(reloadingTime >= maxReloadingTime)
        {
            bullets++;
            reloadingTime = 0f;
        }        
    }
}
