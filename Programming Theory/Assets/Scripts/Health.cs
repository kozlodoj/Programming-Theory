using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int hP = 20;

   
    void Update()
    {
        //check if HP is 0
        if (hP <= 0)
        {
            Destroy(gameObject);
        }
    }
    //get damage
    public void GetDamage(int damage)
    {
        hP -= damage;
        Debug.Log(hP);
    }
}
