using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class callmenu : MonoBehaviour
{


	void Start ()
    {
        StartCoroutine(CallScene());
    }
	
	void Update ()
    {
	
	}

    IEnumerator CallScene()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("menu");
    }
}
