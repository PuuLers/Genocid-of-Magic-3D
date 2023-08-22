using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_1 : MonoBehaviour
{
    public Transform Player;
    public GameObject[] Points;
    public GameObject NearestObject = null;


    private void Start()
    {
        FindNearestObject();
    }



    void FindNearestObject()
    {
        float nearestDistance = Mathf.Infinity;

        foreach (GameObject obj in Points)
        {
            float distance = Vector3.Distance(Player.position, obj.transform.position);

            if (distance < nearestDistance)
            {
                NearestObject = obj;
                nearestDistance = distance;
            }
        }
        Debug.Log(NearestObject);
    }
}

