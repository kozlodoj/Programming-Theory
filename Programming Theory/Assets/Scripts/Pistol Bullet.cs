using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBullet : Bullet
{
    [SerializeField] float speed = 10;
    private float lifeTime = 2f;
    private float timePassed = 0;
    private int damage;

    // Start is called before the first frame update
    void Start()
    {
        Fire(speed);
    }

    private void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed >= lifeTime)
        {
            Destroy(gameObject);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        DealDamage(damage, collision.gameObject);
}
    public override void DealDamage(int damage, GameObject target)
    {
        base.DealDamage(damage, target);
    }
}
