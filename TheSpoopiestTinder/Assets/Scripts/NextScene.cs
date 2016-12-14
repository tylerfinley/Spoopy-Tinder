using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

    AudioClip ehSound;
    AudioClip noSound;
    GameObject noisePlayer;
    //public GameObject ehButton;
    //public GameObject noButton;

    // Use this for initialization
    void Start () {
        ehSound = Resources.Load<AudioClip>("ehSound");
        noSound = Resources.Load<AudioClip>("noSound");
        noisePlayer = GameObject.Find("ResponseSource");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void loadNextScene()
    {
        if (transform.CompareTag("Yes"))
        {
            
            Debug.Log("You said yes!");
            noisePlayer.GetComponent<AudioSource>().PlayOneShot(ehSound);
            //ehButton.SetActive(false);
            //noButton.SetActive(false);
            StartCoroutine(sceneWait2());

        }
        else
        {
            GameObject.Find("Datalogger").GetComponent<Datalogger>().matches.Add(false);
            Debug.Log("You said no!");
            noisePlayer.GetComponent<AudioSource>().PlayOneShot(noSound);
            //ehButton.SetActive(false);
            //noButton.SetActive(false);
            StartCoroutine(sceneWait());
            
        }
        StartCoroutine(sceneWait());
        //int current = SceneManager.GetActiveScene().buildIndex;
        //SceneManager.LoadScene(current+1);
    }

    IEnumerator sceneWait()
    {
        yield return new WaitForSecondsRealtime(2.75f);
        int current = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(current + 1);
    }

    IEnumerator sceneWait2()
    {
        yield return new WaitForSecondsRealtime(1f);
        int current = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(current + 1);
    }
}
