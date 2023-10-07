using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlGenerator : MonoBehaviour
{

    public GameObject[] Rooms;
    public int LevLength = 10;
    public Transform Zero;
    public int pref;
    private GameObject LastRoom;
    public GameObject BossRoom; 

    private void Generate()
    {
        for (int i = 0; i < LevLength + 1; i++)
        {
            int rand = Random.Range(0, Rooms.Length);
            GameObject ActiveRoom = Rooms[rand];

            if (LastRoom == ActiveRoom && i != 0)
            {
                i--;  
            }
            else
            {
                var Cell = Instantiate(ActiveRoom, Zero);
                Cell.transform.localPosition = new Vector3(0, 0, i * pref);
                LastRoom = ActiveRoom;
            }
        }
    }


    private void BossRoomGenerate()
    {
        var Cell = Instantiate(BossRoom, Zero);
        Cell.transform.localPosition = new Vector3(0, 0, (pref + 1) * 10);
    }
    

    void Start()
    {
        Generate();
        BossRoomGenerate();
    }


}
