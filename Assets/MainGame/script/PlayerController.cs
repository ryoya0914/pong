using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public bool AImode;
    public Transform ball;
    public float speed = 5f;
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if(AImode ==true)
        {
            ball = GameObject.Find("ball").transform;
        }
    }

    void Update()
    {
        if(AImode == true)
        {
            
        }
        else
        {
            if (transform.name == "player1")
            {
                if (Input.GetKey("w"))
                {
                    var vel = rb2d.velocity;
                    vel.y = speed;
                    rb2d.velocity = vel;
                }
                else if (Input.GetKey("s"))
                {
                    var vel = rb2d.velocity;
                    vel.y = -1 * speed;
                    rb2d.velocity = vel;
                }
                //なんらかのキーが押されていなければ
                else if (!Input.anyKey)
                {
                    var vel = rb2d.velocity;
                    vel.y = 0.0f;
                    rb2d.velocity = vel;
                }
            }
            else if (transform.name == "player2")
            {
                if (Input.GetKey("o"))
                {
                    var vel = rb2d.velocity;
                    vel.y = speed;
                    rb2d.velocity = vel;
                }
                else if (Input.GetKey("l"))
                {
                    var vel = rb2d.velocity;
                    vel.y = -1 * speed;
                    rb2d.velocity = vel;
                }
                else if (!Input.anyKey)
                {
                    var vel = rb2d.velocity;
                    vel.y = 0.0f;
                    rb2d.velocity = vel;
                }
            }
        }


    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}