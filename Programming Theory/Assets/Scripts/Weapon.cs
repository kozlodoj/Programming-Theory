using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private bool canShoot = true;

    //shoot mechanic
    public void Shoot(Vector3 position, Quaternion rotation,int damage, GameObject bullet, float coolDown)
    {
        //check if can shoot
        if (canShoot)
        {
                Instantiate(bullet, position, rotation);
            gameObject.GetComponent<AmmoScript>().SubtractAmmo();
            
            //start timer to next shot
            StartCoroutine(CoolDown(coolDown));
          
        }

    }

    //timer for next shot
    private IEnumerator CoolDown (float coolDownTime)
    {

        canShoot = false;
        yield return new WaitForSeconds(coolDownTime);
        canShoot = true;
    }
}
