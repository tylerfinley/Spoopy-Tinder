using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void loadNextScene()
    {
        if (transform.CompareTag("Yes"))
        {
            GameObject.Find("Datalogger").GetComponent<Datalogger>().matches.Add(true);
            Debug.Log("You said yes!");
        }
        else
        {
            Debug.Log("You said no!");
        }
        int current = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(current+1);
    }
}
