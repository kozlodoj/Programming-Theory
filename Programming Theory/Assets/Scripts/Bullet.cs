using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public virtual void Fire(float speed)
    {
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speed, ForceMode.Impulse);

    }

    public virtual void DealDamage(int damage, GameObject target)
    {
        target.health -= damage;

    }

}
