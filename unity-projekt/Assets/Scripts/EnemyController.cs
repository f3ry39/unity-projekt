using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    MovingEnemy movingEnemy;
    DeathsController deathsController;
    float maxSpeed;
    private void Start()
    {
        movingEnemy = GetComponent<MovingEnemy>();
        maxSpeed = movingEnemy.speed;
        deathsController = GameObject.Find("Manager").GetComponent<DeathsController>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("fail");
            movingEnemy.speed = 0;
            deathsController.IncrementCounter();
            Invoke("Reset", 0.25f);
        }
    }

    private void Reset()
    {
        movingEnemy.speed = maxSpeed;
    }
}
