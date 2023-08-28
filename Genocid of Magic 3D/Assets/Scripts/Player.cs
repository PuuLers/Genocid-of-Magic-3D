using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    static public Transform[] ActiveRoomArray;
    public float Speed = 5f;
    static public int ActivePoint;
    public Transform marker;
    public GameObject bullet;
    public Transform shotPoint;
    public int bullets;
    public int money;
    public TextMeshPro bulletsText;
    public TextMesh moneyText;

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

    protected void Rotate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.transform.rotation = marker.rotation;
        }
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, shotPoint.position, marker.rotation);
        }   
    }

    void Start()
    {
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        //bulletsText.text = bullets.ToString();
        //moneyText.text = money.ToString();
        GoToPoint();
    }

 
}
