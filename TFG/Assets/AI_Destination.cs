using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AI_Destination : MonoBehaviour
{
    private float minX = -47f;
    private float maxX = 47f;
    private float minZ = 12.5f;
    private float maxZ = 77.5f;

    private bool destinationReached;

    void Start()
    {
        destinationReached = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (destinationReached)
        {
            float randomX = Random.Range(minX, maxX);
            float randomZ = Random.Range(minZ, maxZ);
            
            Vector3 newPos = new Vector3(randomX, 0f, randomZ);
            newPos.x = Mathf.Clamp(newPos.x, minX, maxX);
            newPos.z = Mathf.Clamp(newPos.z, minZ, maxZ);

            transform.position = newPos;

            destinationReached = false;
        }


    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        if (other.gameObject.CompareTag("RedTank"))
        {
            destinationReached = true;
        }
    }
}
