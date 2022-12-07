using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject player;
    public Transform teleportPosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = teleportPosition.position;
    }
}
