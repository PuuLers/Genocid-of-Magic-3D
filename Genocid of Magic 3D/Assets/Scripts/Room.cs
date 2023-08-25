using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Room : MonoBehaviour
{

    public Transform[] Points;
    public Transform[] SpawnPoints;
    public GameObject[] Enemies;



    public void SendingArray()
    {
        Player.ActiveRoomArray = Points;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.ActivePoint = 0;
            Player.ActiveRoomArray = Points;
        }
    }
    
    void SpawnEnemies()
    {
        for (int i = 0; i < SpawnPoints.Length; i++)
        {
            int randEnemy = Random.Range(0, Enemies.Length);
            int activePoints = 0;
            new Vector3 = SpawnPoints[activePoints];
            new Vector3 = SpawnPoints[activePoints];
            Instantiate(Enemies[randEnemy], , Quaternion.identity);
            activePoints =+ 1;
            

        }
    }


}

