using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static GameObject weapon;

    [SerializeField] List<GameObject> Weapons = new List<GameObject>();

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;

        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void setWeapon(int weaponButton)
    {
        weapon = Weapons[weaponButton];
        SceneManager.LoadScene(1);
        Debug.Log(weapon);
    }


}
