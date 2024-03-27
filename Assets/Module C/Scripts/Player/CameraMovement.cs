using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : DataController
{
    [SerializeField] GameObject player;
    [SerializeField] float speedCameraMovement;

    float[] playerPosition;

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
    }

    void Update()
    {
        Vector3 targetPosition = player.transform.position;
        targetPosition.z = -10;

        this.gameObject.transform.position = Vector3.Lerp(this.gameObject.transform.position, targetPosition, Time.deltaTime * speedCameraMovement);
    }
}
