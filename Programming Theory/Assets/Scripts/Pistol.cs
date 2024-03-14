using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    [SerializeField] GameObject bullet;
    [SerializeField] float coolDown = 1;
    private int damage = 10;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Shoot(transform.position, transform.rotation, damage, bullet, coolDown);

        }
    }
}
