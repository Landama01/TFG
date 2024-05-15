using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueTankMovement : MonoBehaviour
{
    public float TankSpeed = 10f;

    private float minX = -47f;
    private float maxX =  47f;
    private float minZ = -77.5f;
    private float maxZ = -12.5f;

    float HMovement = 0f;
    float VMovement = 0f;

    // Update is called once per frame
    void Update()
    {
        HMovement = 0f;
        VMovement = 0f;

        if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }
        if (Input.GetKey(KeyCode.W))
        {
            MoveUp();
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveDown();
        }

        Vector3 movement = new Vector3(HMovement, 0f, VMovement) * TankSpeed * Time.deltaTime;

        Vector3 newPos = transform.position + movement;
        newPos.x = Mathf.Clamp(newPos.x, minX, maxX);
        newPos.z = Mathf.Clamp(newPos.z, minZ, maxZ);

        transform.position = newPos;
    }

    void MoveRight()
    {
        HMovement = 1f;
    }
    void MoveLeft()
    {
        HMovement = -1f;
    }
    void MoveUp()
    {
        VMovement = 1f;
    }
    void MoveDown()
    {
        VMovement = -1f;
    }
}
