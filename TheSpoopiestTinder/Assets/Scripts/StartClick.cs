using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Next()
    {
        int current = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(current + 1);
    }
}
