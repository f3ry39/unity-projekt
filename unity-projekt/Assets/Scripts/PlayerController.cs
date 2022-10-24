using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Animator anim;
    bool dirToRight = true; 

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalMove = Input.GetAxis ("Horizontal");

        anim.SetFloat("speed", Mathf.Abs (horizontalMove)); //przejscie z animacji na druga animacje

        if(horizontalMove < 0 && dirToRight)
        {
            Flip();
        }

        if (horizontalMove > 0 && !dirToRight)
        {
            Flip();
        }

    }
    void Flip()
    {

        dirToRight = !dirToRight;
        Vector3 heroScale = gameObject.transform.localScale;
        heroScale.x *= -1;
        gameObject.transform.localScale = heroScale; //obracanie bohatera 

    }
}
