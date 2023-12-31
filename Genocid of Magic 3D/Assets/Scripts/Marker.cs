using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Marker : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 5f;

    private void Update()
    {
        Vector3 currentRotation = transform.rotation.eulerAngles;
        currentRotation.y += rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(currentRotation);
        RotateMarker();
    }

    private void RotateMarker()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotationSpeed *= -1;
        }
    }

}

