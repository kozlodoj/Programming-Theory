using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public virtual void Move(float speed, float magnitude)
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * speed * Time.deltaTime, ForceMode.Force);
        if (gameObject.GetComponent<Rigidbody>().velocity.magnitude > magnitude)
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(gameObject.GetComponent<Rigidbody>().velocity, magnitude);
        }

    }
}
