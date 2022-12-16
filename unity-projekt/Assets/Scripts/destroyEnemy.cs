using UnityEngine;

public class destroyEnemy : MonoBehaviour
{
    public AudioClip clip;
    public GameObject deathEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<jumpingOnEnemyHead>())
        {
            Destroy(transform.parent.gameObject); //usuwanie rodzica czyli obiektu AngryPig
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}

