using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstEnemy : Enemy
{
    private float speed = 250;
    private float magnitude = 10;
    [SerializeField] float boundry = 10;
    private bool right = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x > boundry)
        {
            right = false;
        }
        if (gameObject.transform.position.x < -boundry)
        {
            right = true;
        }

        if (right)
        {
            Move(speed, magnitude);
        }
        else
        {
            Move(-speed, magnitude);
        }
        
    }
}
