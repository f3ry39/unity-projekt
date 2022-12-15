using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpadesController : MonoBehaviour
{
    DeathsController deathsController;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        deathsController = GameObject.Find("Manager").GetComponent<DeathsController>();
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("fail");
            deathsController.IncrementCounter();
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
