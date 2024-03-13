using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //move object
    public void Move(float speed, float magnitude, float boundry, Vector3 direction)
    {
        if (direction == Vector3.right)
        {
            //check if it should move right
            bool right = IsDirectionRight(boundry);
            // if right apply speed if left -speed
            if (right)
            {
                Movement(speed, magnitude, direction);
            }
            else
            {
                Movement(-speed, magnitude, direction);
            }
        }

        if (direction == Vector3.up)
        {
            //check if it should move UP
            bool up = IsDirectionUp(boundry);
            // if right apply speed if left -speed
            if (up)
            {
                Movement(speed, magnitude, direction);
            }
            else
            {
                Movement(-speed, magnitude, direction);
            }
        }


    }
    //calculate the movement
    private void Movement(float speed, float magnitude, Vector3 direction)
    {
        gameObject.GetComponent<Rigidbody>().AddForce(direction * speed * Time.deltaTime, ForceMode.Force);
        if (gameObject.GetComponent<Rigidbody>().velocity.magnitude > magnitude)
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(gameObject.GetComponent<Rigidbody>().velocity, magnitude);
        }
    }
    //check if the direction is right
    private bool IsDirectionRight (float boundry)
    {
        if (gameObject.transform.position.x > boundry)
        {
            return false;

        }
        if (gameObject.transform.position.x < -boundry)
        {
            return true;
        }
        if (gameObject.GetComponent<Rigidbody>().velocity.x < 0)
        {
            return false;
        }


        return true;
    }
    //check if direction is UP
    private bool IsDirectionUp (float boundry)
    {
        if (gameObject.transform.position.y > boundry)
        {
            return false;

        }
        if (gameObject.transform.position.y < -boundry)
        {
            return true;
        }
        if (gameObject.GetComponent<Rigidbody>().velocity.y < 0)
        {
            return false;
        }


        return true;
    }

}
