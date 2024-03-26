using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rgPlayer;
    [SerializeField] private ButtonMovementController buttonMovementController;
    [SerializeField] private float speed;

    void Start()
    {
        rgPlayer = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector2 movement = buttonMovementController.GetMovementVector2();
        rgPlayer.velocity = movement * speed;
    }
}
