using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float speedCameraMovement;

    void Start()
    {
    }

    void Update()
    {
        Vector3 targetPosition = player.transform.position;
        targetPosition.z = -10;

        this.gameObject.transform.position = Vector3.Lerp(this.gameObject.transform.position, targetPosition, Time.deltaTime * speedCameraMovement);
    }
}
