using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScreenLoad : MonoBehaviour
{

	void Start ()
    {
	
	}
	
	void Update ()
    {
	
	}

    public void mainLoad()
    {

        SceneManager.LoadScene("main");

    }

    public void AImodeLoad()
    {

        SceneManager.LoadScene("aimode");

    }
}
