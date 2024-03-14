using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstEnemy : Enemy
{
    private float speed = 250;
    private float magnitude = 10;
    [SerializeField] float boundry = 10;
   

    void Update()
    {
        //the movement
        Move(speed, magnitude, boundry, Vector3.right);
    }
}
