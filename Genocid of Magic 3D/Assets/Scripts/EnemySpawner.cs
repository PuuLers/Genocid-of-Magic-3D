using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] EnemyEasy;
    public GameObject[] EnemyMiddle;
    public GameObject[] EnemyHard;
    static public int Dificult = 0;



    private void Spawn()
    {
        if (Dificult == 0)
        {
            int rand = Random.Range(0, EnemyEasy.Length);
            Instantiate(EnemyEasy[rand], transform.position, Quaternion.identity);
        }
        else if (Dificult == 1)
        {
            int rand = Random.Range(0, EnemyMiddle.Length);
            Instantiate(EnemyEasy[rand], transform.position, Quaternion.identity);
        }
        else
        {
            int rand = Random.Range(0, EnemyHard.Length);
            Instantiate(EnemyEasy[rand], transform.position, Quaternion.identity);
        }
    }

    void Start()
    {
        Spawn();
    }


}
