using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
    public float Speed;
    

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Room"))
        {
            Destroy(gameObject);
        }
    }






}
