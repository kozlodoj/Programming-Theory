using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //fire mechanick
    public virtual void Fire(float speed)
    {
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speed, ForceMode.Impulse);

    }
    //damage mechanic
    public virtual void DealDamage(int damage, GameObject target)
    {
        if (target.CompareTag("Enemy"))
         {
            target.GetComponent<Health>().GetDamage(damage);
         }
    }

}
