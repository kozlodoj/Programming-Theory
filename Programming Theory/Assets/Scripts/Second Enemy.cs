using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondEnemy : Enemy
{

    private float speed = 250;
    private float magnitude = 10;
    [SerializeField] float boundry = 5;

   
    void Update()
    {

        // INHERITANCE
        // POLYMORPHISM
        //the movement
        Move(speed, magnitude, boundry, Vector3.up);
    }

    

}
