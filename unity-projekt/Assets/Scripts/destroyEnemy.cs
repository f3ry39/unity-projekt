using UnityEngine;

public class destroyEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<jumpingOnEnemyHead>())
        {
            Destroy(transform.parent.gameObject); //usuwanie rodzica czyli obiektu AngryPig
        }
    }
}

