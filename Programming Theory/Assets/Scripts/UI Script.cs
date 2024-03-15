using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScript : MainManager
{
    [SerializeField] TextMeshProUGUI ammoText;
    [SerializeField] TextMeshProUGUI weaponText;
    [SerializeField] TextMeshProUGUI reloadText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetAmmo(int ammo)
    {
        ammoText.SetText("ammo: " + ammo);
    }

    public void SetWeaponText(string weapon)
    {
        weaponText.SetText(weapon);
    }

    public void ReloadingText(bool reloading)
    {
        if (reloading)
        {
            reloadText.gameObject.SetActive(true);

        }
        else {
            reloadText.gameObject.SetActive(false);
        }
    }
}
