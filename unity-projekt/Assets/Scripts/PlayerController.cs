using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float heroSpeed;
    Animator anim;
    bool dirToRight = true; 
    public Rigidbody2D rgdBody;
    public float launchForce; //trampolina

    public float jumpForce;

    private bool onTheGround;
    public Transform groundTester;
    private float radius = 0.1f;
    public LayerMask layersToMask;
    public Transform startPoint;

    public AudioClip clip;
    public AudioClip clip2;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent <Animator> ();
        rgdBody = GetComponent <Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {

        if(anim.GetCurrentAnimatorStateInfo(0).IsName("Dead"))
        {
            rgdBody.velocity = Vector2.zero;
            return;
        }

        onTheGround = Physics2D.OverlapCircle(groundTester.position, radius, layersToMask);

        float horizontalMove = Input.GetAxis ("Horizontal");
        rgdBody.velocity = new Vector2 (horizontalMove * heroSpeed, rgdBody.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && onTheGround)
        { 
            rgdBody.AddForce(new Vector2(0f, jumpForce));
            anim.SetTrigger("jump");
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }

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

    public void RestartHero()
    {
        gameObject.transform.position = startPoint.position;
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Trampoline"))
        {
            rgdBody.velocity = Vector2.up * launchForce;
            AudioSource.PlayClipAtPoint(clip2, transform.position);
        }
    }
}
