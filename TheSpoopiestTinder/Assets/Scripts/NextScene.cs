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
        if (transform.parent.gameObject.name == "Eh")
        {
            GameObject.Find("Datalogger").GetComponent<Datalogger>().matches.Add(true);
            Debug.Log("You said yes!");
        }
        else
        {
            GameObject.Find("Datalogger").GetComponent<Datalogger>().matches.Add(false);
            Debug.Log("You said no!");
        }
        int current = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(current+1);
    }
}
