using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : DataController
{
    private Rigidbody2D rgPlayer;
    [SerializeField] private ButtonMovementController buttonMovementController;
    [SerializeField] private float speed;
    private float[] playerPosition;

    private void Awake()
    {
        playerPosition = LoadPositionPlayerData();
    }

    void Start()
    {
        if (playerPosition != null)
        {
            gameObject.transform.position = new Vector3(playerPosition[0], playerPosition[1], 0);
        }
        rgPlayer = GetComponent<Rigidbody2D>();
        InvokeRepeating("SavePosition", 0f, 0.5f);
    }

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector2 movement = buttonMovementController.GetMovementVector2();
        rgPlayer.velocity = movement * speed;

        if (movement.x == 0 && movement.y == 0)
        {
            GetComponent<Animator>().SetBool("Right", false);
            GetComponent<Animator>().SetBool("Left", false);
            GetComponent<Animator>().SetBool("Back", false);
            GetComponent<Animator>().SetBool("Front", false);
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        } else
        if (movement.x == 1 && movement.y == 0)
        {
            GetComponent<Animator>().SetBool("Right", true);
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        if (movement.x == -1 && movement.y == 0)
        {
            GetComponent<Animator>().SetBool("Right", true);
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        if (movement.x == 0 && movement.y == 1)
        {
            GetComponent<Animator>().SetBool("Back", true);
        }
        else
        if (movement.x == 0 && movement.y == -1)
        {
            GetComponent<Animator>().SetBool("Front", true);
        } else
        {
            if (movement.x == 1)
            {
                GetComponent<Animator>().SetBool("Right", true);
                gameObject.transform.localScale = new Vector3(1, 1, 1);
            }
            else if(movement.x == -1)
            {
                GetComponent<Animator>().SetBool("Right", true);
                gameObject.transform.localScale = new Vector3(-1, 1, 1);
            }
        }
    }

    private void SavePosition()
    {
        SavePositionPlayerData(gameObject.transform.position.x, gameObject.transform.position.y);
    }
}
