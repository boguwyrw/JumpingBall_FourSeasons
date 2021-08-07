using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    private Rigidbody boardRigidbody;
    private bool canBreakBoard = false;
    private float delayValue = 0.15f;

    private void Start()
    {
        boardRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (canBreakBoard)
        {
            StartCoroutine(BreakBoardDelay());
        }
    }

    private IEnumerator BreakBoardDelay()
    {
        yield return new WaitForSeconds(delayValue);
        boardRigidbody.isKinematic = false;
        boardRigidbody.useGravity = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 3)
        {
            canBreakBoard = true;
        }
    }
}
