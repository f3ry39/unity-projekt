using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    public Transform navigationStartPoint;
    public Transform navigationEndPoint;

    private Vector2 startPoint;
    private Vector2 endPoint;
    public float speed;

    private Vector2 currentEnemyPosition;
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
        currentEnemyPosition = Vector2.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time * speed, 1));
        transform.position = currentEnemyPosition;
    }
}
