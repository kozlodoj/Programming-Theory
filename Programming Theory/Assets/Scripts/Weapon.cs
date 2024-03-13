using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private bool canShoot = true;


    public void Shoot(Vector3 position, Quaternion rotation,int damage, GameObject bullet, float coolDown)
    {
        if (canShoot)
        {
                Instantiate(bullet, position, rotation);
                StartCoroutine(CoolDown(coolDown));
        }

    }

    private IEnumerator CoolDown (float coolDownTime)
    {

        canShoot = false;
        yield return new WaitForSeconds(coolDownTime);
        canShoot = true;
    }
}
