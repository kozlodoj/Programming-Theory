using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        setWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void setWeapon()
    {

        string weaponName = GameManager.weapon.name;
        GameObject.Find("Main Camera").transform.Find(weaponName).gameObject.SetActive(true);

    }
}
