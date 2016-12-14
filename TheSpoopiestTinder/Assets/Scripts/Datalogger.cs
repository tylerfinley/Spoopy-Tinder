using UnityEngine;
using System.Collections;

public class Datalogger : MonoBehaviour {
    public ArrayList matches = new ArrayList();
	// Use this for initialization
	void Start () {
	
	}
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
	
	// Update is called once per frame
	void Update () {

	}
}
