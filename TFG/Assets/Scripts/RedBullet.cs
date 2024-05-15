using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RedBullet : MonoBehaviour
{
    public float bulletSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * bulletSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("BlueTank"))
        {
            Destroy(gameObject);
        }     
        if(collision.gameObject.CompareTag("Limits"))
        {
            Destroy(gameObject);
        }     
        
    }
}
