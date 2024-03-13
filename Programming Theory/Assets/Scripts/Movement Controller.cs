using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private float horizontalAxis;
    private float verticalAxis;
    private float speed = 0.1f;
    private float moveBoundX = 20f;
    private float moveBoundY = 10f;


    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal") * speed;
        verticalAxis = Input.GetAxis("Vertical") * speed;

        Move(horizontalAxis, verticalAxis);
    }

    private void Move(float horizontalAxis, float verticalAxis)
    {
        transform.Translate(horizontalAxis, verticalAxis, 0);

        if (transform.position.x > moveBoundX)
        {
            transform.position = new Vector3(moveBoundX, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -moveBoundX)
        {
            transform.position = new Vector3(-moveBoundX, transform.position.y, transform.position.z);
        }
        if (transform.position.y > moveBoundY)
        {
            transform.position = new Vector3(transform.position.x, moveBoundY, transform.position.z);
        }
        if (transform.position.y < -moveBoundY)
        {
            transform.position = new Vector3(transform.position.x, -moveBoundY, transform.position.z);
        }
    }
}
