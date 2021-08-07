using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBridge : MonoBehaviour
{
    private float startScaleZ = 0.0f;
    private float valueMax = 20.0f;
    private float scalingSpeed = 2.5f;
    private bool isBigger = true;

    private void Start()
    {
        startScaleZ = transform.localScale.z;
    }

    private void Update()
    {
        if (transform.localScale.z > valueMax)
            isBigger = false;

        if (transform.localScale.z < startScaleZ)
            isBigger = true;

        if (isBigger)
            ScalingMovingBridge(scalingSpeed);
        else
            ScalingMovingBridge(-scalingSpeed);
    }

    private void ScalingMovingBridge(float scalingSpeedDirection)
    {
        float scaleZ = transform.localScale.z + scalingSpeedDirection * Time.deltaTime;
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, scaleZ);
    }
}
