using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int hP = 20;

   
    void Update()
    {
        if (hP <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void GetDamage(int damage)
    {
        hP -= damage;
    }
}
