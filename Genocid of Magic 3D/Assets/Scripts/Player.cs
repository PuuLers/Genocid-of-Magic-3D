using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform playerTransform;
    static public Transform[] ActiveRoomArray;
  
  
    public float Speed = 5f;
    private int ActivePoint;


    private void GoToPoint()
    {

        if (ActivePoint < ActiveRoomArray.Length)
        {
            Transform targetPoint = ActiveRoomArray[ActivePoint];
            transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, Speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
            {
                ActivePoint++;
            }
        }
    }


    void Start()
    {
        playerTransform = GetComponent<Transform>();
        
    }
    
    void FixedUpdate()
    {
        GoToPoint();
    }
}
