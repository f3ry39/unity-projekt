using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPoint : MonoBehaviour
{
    RestartPointsManager restartPointsManager;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        restartPointsManager = GameObject.Find("Manager").GetComponent<RestartPointsManager>();

        if(restartPointsManager == null)
        {
            Debug.LogError("RestartPointsManager nie zosta³ znaleziony");
        }

        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if  (other.gameObject.tag == "Player")
        {
            restartPointsManager.UpdateStartPoint(this.gameObject.transform);
            spriteRenderer.color = new Color(0.3f, 0.6f, 0.6f);
        }
    }
}
