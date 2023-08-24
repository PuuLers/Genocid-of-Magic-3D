using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
   
    
    public Transform[] Points;
    


    public void SendingArray()
    {
        Player.ActiveRoomArray = Points;
    }
    



    private void Start()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SendingArray();
        }
    }



}

