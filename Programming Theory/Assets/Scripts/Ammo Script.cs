using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : Weapon
{
    [SerializeField] int ammo = 8;
    private int currentAmmo;
    [SerializeField] float reloadTime = 4f;
    public bool isReloading = false;

    private void Start()
    {
        //set magazine to capacity
        currentAmmo = ammo;
    }

    //subtract ammo
    public void SubtractAmmo()
    {
        currentAmmo--;
        if (currentAmmo <= 0)
        {
            Reloading();

        }
    }
    //reload
    public void Reloading()
    {
        
            isReloading = true;
            StartCoroutine(ReloadProcess(reloadTime));
        
       
    }
    private IEnumerator ReloadProcess (float reloadTime)
    {
        yield return new WaitForSeconds(reloadTime);
        isReloading = false;
        currentAmmo = ammo;

    }
}
