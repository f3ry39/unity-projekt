using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector2 startPoint;
    public Vector2 endPoint;
    public float speed;

    private Vector2 currentPlatformPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPlatformPosition = Vector2.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time, 1));
        transform.position = currentPlatformPosition;
        //transform.Translate(speed, 0, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);
        other.transform.parent = transform;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name + " - OUT");
        other.transform.parent = null;
    }
}
