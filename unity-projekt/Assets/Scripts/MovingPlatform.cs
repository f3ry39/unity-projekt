using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform navigationStartPoint;
    public Transform navigationEndPoint;

    private Vector2 startPoint;
    private Vector2 endPoint;
    public float speed;

    private Vector2 currentPlatformPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPoint = navigationStartPoint.position;
        endPoint = navigationEndPoint.position;
        Destroy(navigationStartPoint.gameObject);
        Destroy(navigationEndPoint.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        currentPlatformPosition = Vector2.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time * speed, 1));
        transform.position = currentPlatformPosition;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.transform.parent = transform;
            other.attachedRigidbody.Sleep();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.parent = null;
        }
    }
}
