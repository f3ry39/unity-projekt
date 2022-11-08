using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingHero : MonoBehaviour
{
    public GameObject hero;
    public float smooth; //czas w jakim dokona sie zmiana

    private Vector3 currentVelocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newCameraPosition = new Vector3(hero.transform.position.x, transform.position.y, transform.position.z);

        transform.position = Vector3.SmoothDamp(transform.position, newCameraPosition, ref currentVelocity, smooth); //zapobiegniecie "sztywnej kamery"
    }
}
