using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalCount : MonoBehaviour
{
    public GameObject ball;
    public bool right;
    public Text scoreText;
    private int score = 0;

    void Start()
    {
        scoreText.text = "0";
    }

    void Update()
    {

    }

    void OnGUI()
    {

        if (GUILayout.Button("Reload"))
        {

            Application.LoadLevel("main");
        }
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ball")
        {

            if (right == true)
            {
                ball.transform.position = new Vector3(0f, 0f, 0f);
                score++;
                scoreText.text = score.ToString();
                if (score >= 7)
                {
                    SceneManager.LoadScene("call2");
                }


            }
            else
            {
                ball.transform.position = new Vector3(0f, 0f, 0f);
                score++;
                scoreText.text = score.ToString();
                if (score >= 7)
                {
                    SceneManager.LoadScene("call");
                }
            }
        }
    }


}
