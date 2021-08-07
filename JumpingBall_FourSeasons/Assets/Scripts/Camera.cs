using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private GameController gameController;
    [SerializeField] private Transform player;

    private void Start()
    {
        
    }

    private void Update()
    {
        CameraMovement();
        transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
    }

    private void CameraMovement()
    {
        transform.Translate(Vector3.right * gameController.playerSpeed * Time.deltaTime);
    }
}
