using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MillArm : MonoBehaviour
{
    private GameObject middlePoint;
    private float rotationSpeed = 15.0f;

    void Start()
    {
        middlePoint = transform.parent.gameObject;
    }

    void Update()
    {
        transform.RotateAround(middlePoint.transform.position, Vector3.right, rotationSpeed * Time.deltaTime);
        transform.rotation = middlePoint.transform.rotation;
    }
}
