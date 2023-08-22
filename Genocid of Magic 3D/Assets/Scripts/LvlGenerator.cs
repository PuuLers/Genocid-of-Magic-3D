using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlGenerator : MonoBehaviour
{

    public GameObject[] Rooms;
    public int LevLength = 10;
    public Transform Zero;
    public int pref;


    private void Generate()
    {
        for (int i = 0; i < LevLength; i++)
        {
            int rand = Random.Range(0, Rooms.Length);
            var Cell = Instantiate(Rooms[rand], Zero);
            Cell.transform.localPosition = new Vector3(0, 0, i * pref);
        }
    }








    void Start()
    {
        Generate();

    }


}
