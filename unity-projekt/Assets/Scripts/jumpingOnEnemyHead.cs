using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpingOnEnemyHead : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D headRb; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        headRb.velocity = new Vector2(headRb.velocity.x, 0f);
    }
}
