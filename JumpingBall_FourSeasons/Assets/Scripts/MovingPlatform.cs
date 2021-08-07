using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float platformSpeed = 0.0f;
    [SerializeField] private bool isMovingUp = true;

    private float startPositionY = 3.0f;
    private float valueMaxMin = 18.0f;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (transform.position.y > startPositionY + valueMaxMin)
            isMovingUp = false;

        if (transform.position.y < startPositionY - valueMaxMin)
            isMovingUp = true;

        if (isMovingUp)
            transform.Translate(Vector3.up * platformSpeed * Time.deltaTime);
        else
            transform.Translate(Vector3.down * platformSpeed * Time.deltaTime);
    }
}
