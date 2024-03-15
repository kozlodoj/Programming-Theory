using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] List<GameObject> Enemies = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies(3);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length < Enemies.Count)
        {
            SpawnEnemies(RandomNumber(Enemies.Count));
        }
    }

    private void SpawnEnemies(int amount)
    {
        if (amount <= Enemies.Count)
        {
            for (int i = 0; i < amount; i++)
            {
                Instantiate(Enemies[i], RandomPos(), transform.rotation);
            }

        }
    }
    //ABSTRACTION
    private Vector3 RandomPos()
    {
        return new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(0, 5f));
    }
    //ABSTRACTION
    private int RandomNumber(int maxRange)
    {
        return  Random.Range(0, maxRange);
    }
}
