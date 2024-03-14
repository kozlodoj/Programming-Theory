using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBullet : Bullet
{
    [SerializeField] float speed = 10;
    private float lifeTime = 2f;
    private float timePassed = 0;
    private int damage = 10;

    
    void Start()
    {
        //fire the bullet
        Fire(speed);
    }

    private void Update()
    {
        //check for life time
        timePassed += Time.deltaTime;
        if (timePassed >= lifeTime)
        {
            Destroy(gameObject);

        }
    }
    //collision check
    private void OnCollisionEnter(Collision collision)
    {
        //deal damage
        DealDamage(damage, collision.gameObject);
        
}


}
