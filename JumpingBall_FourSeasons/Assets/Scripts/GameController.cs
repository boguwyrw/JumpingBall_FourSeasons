using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [HideInInspector] public float playerSpeed = 0;

    private float playerSlowSpeed = 1;
    private float playerNormalSpeed = 2;
    private float playerFastSpeed = 4;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            StartGame();

        if (Input.GetKeyDown(KeyCode.Alpha1))
            SetSlowSpeed();

        if (Input.GetKeyDown(KeyCode.Alpha2))
            SetNormalSpeed();

        if (Input.GetKeyDown(KeyCode.Alpha3))
            SetFastSpeed();
    }

    public void StartGame()
    {
        playerSpeed = playerNormalSpeed;
    }

    public void SetSlowSpeed()
    {
        playerSpeed = playerSlowSpeed;
    }

    public void SetNormalSpeed()
    {
        playerSpeed = playerNormalSpeed;
    }

    public void SetFastSpeed()
    {
        playerSpeed = playerFastSpeed;
    }
}
