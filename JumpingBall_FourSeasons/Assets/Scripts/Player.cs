using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    private Rigidbody playerRigidbody;
    private float playerJumpingForce = 9.0f;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        PlayerMovement();

        PlayerJumping();

        //Debug.Log(playerRigidbody.velocity.y);
    }

    private void PlayerMovement()
    {
        transform.Translate(Vector3.forward * gameController.playerSpeed * Time.deltaTime);
    }

    public void PlayerJumping()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            playerRigidbody.AddForce(Vector3.up * playerJumpingForce, ForceMode.Impulse);
    }
}
