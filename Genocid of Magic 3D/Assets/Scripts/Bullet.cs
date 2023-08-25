using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Range(0.1f, 50f)]
    public int Spread = 10;
    public float Speed;
    public static int Damage;
    public LayerMask WhatIsSolid;
    public float distance;

    private void Start()
    {
        transform.rotation *= Quaternion.Euler(0f, 0f, Random.Range(-Spread, Spread));
    }

}
