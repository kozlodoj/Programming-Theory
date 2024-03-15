using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdEnemy : Enemy
{

    private float speed = 250;
    private float magnitude = 10;
    [SerializeField] float boundry = 10;

    
    void Update()
    {
        // INHERITANCE
        // POLYMORPHISM
        //the movement
        Move(speed, magnitude / 2, boundry, Vector3.up);
        Move(speed, magnitude, boundry, Vector3.right);
    }
}
