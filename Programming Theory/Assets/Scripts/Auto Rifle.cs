using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRifle : Weapon
{
    [SerializeField] GameObject bullet;
    [SerializeField] float coolDown = 0.3f;
    private int damage = 5;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Shoot(transform.position, transform.rotation, damage, bullet, coolDown);

        }
    }
}
