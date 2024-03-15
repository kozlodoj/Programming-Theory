using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    private GameObject mainCamera;
    private UIScript UI;

    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
        UI = GameObject.Find("UI").GetComponent<UIScript>();
        setWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void setWeapon()
    {

        string weaponName = GameManager.weapon.name;
        mainCamera.transform.Find(weaponName).gameObject.SetActive(true);
        UI.SetWeaponText(weaponName.ToString());

    }
}
