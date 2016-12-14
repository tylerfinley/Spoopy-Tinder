using UnityEngine;
using System.Collections;

public class backgroundMusic : MonoBehaviour {

    public GameObject soundPlayer;
    public GameObject soundPlayer2;

	// Use this for initialization
	void Awake () {
        soundPlayer = GameObject.Find("RoomSounds");
        soundPlayer2 = GameObject.Find("RoomSounds (1)");
        DontDestroyOnLoad(soundPlayer);
        DontDestroyOnLoad(soundPlayer2);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
