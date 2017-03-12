using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb2d;


    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
        StartCoroutine(StartScene());

    }
	
	void Update ()
    {

    }

    IEnumerator StartScene()
    {
        yield return new WaitForSeconds(2);
        rb2d.velocity = new Vector2(6f, 6f);
    }
}
