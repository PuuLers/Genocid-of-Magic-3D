using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 10f;

    private void Update()
    {
        Vector3 currentRotation = transform.rotation.eulerAngles;
        currentRotation.y += rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(currentRotation);
    }
}
