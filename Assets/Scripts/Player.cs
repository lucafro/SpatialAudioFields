using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 playerPosition;       // Keeps track of where Player will be teleported.

    [SerializeField] float playerHeight = 1.75f;

    void OnEnable()
    {
        TeleportManager.DoTeleport += MoveTo;
    }

    void OnDisable()
    {
        TeleportManager.DoTeleport -= MoveTo;
    }

    void MoveTo(Transform destTransform)
    {
        // Set the new position.
        playerPosition = destTransform.position;
        // Player's eye level should be playerHeight above the new position.
        playerPosition.y += playerHeight;
        // Move Player.
        transform.position = playerPosition;
    }
}