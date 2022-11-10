using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpadesController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("fail");
        }
    }
}
