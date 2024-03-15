using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : Weapon
{
    [SerializeField] int ammo = 8;
    private int currentAmmo;
    [SerializeField] float reloadTime = 4f;
    public bool isReloading = false;
    private UIScript UI;

    private void Start()
    {
        UI = GameObject.Find("UI").GetComponent<UIScript>();
        //set magazine to capacity
        currentAmmo = ammo;
        UI.SetAmmo(currentAmmo);
    }

    //subtract ammo
    public void SubtractAmmo()
    {
        currentAmmo--;
        UI.SetAmmo(currentAmmo);
        if (currentAmmo <= 0)
        {
            Reloading();

        }
    }
    //reload
    public void Reloading()
    {
        
            isReloading = true;
        UI.ReloadingText(isReloading);
            StartCoroutine(ReloadProcess(reloadTime));
        
       
    }
    private IEnumerator ReloadProcess (float reloadTime)
    {
        yield return new WaitForSeconds(reloadTime);
        isReloading = false;
        UI.ReloadingText(isReloading);
        currentAmmo = ammo;
        UI.SetAmmo(currentAmmo);

    }
}
