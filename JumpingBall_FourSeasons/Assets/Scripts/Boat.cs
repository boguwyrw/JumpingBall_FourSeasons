using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    private float startPositionZ = 0.0f;
    private float valueMaxMin = 6.5f;
    private float movementSpeed = 2.2f;
    private bool isMovingForward = true;

    private void Start()
    {
        startPositionZ = transform.position.z;
    }

    private void Update()
    {
        if (transform.position.z > startPositionZ + valueMaxMin)
            isMovingForward = false;

        if (transform.position.z < startPositionZ - valueMaxMin)
            isMovingForward = true;

        if (isMovingForward)
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        else
            transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
    }
}
