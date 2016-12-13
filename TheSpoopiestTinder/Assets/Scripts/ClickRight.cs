using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickRight : MonoBehaviour {
    public Button rightPic;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;

	// Use this for initialization
	void Start () {
        Button btn = rightPic.GetComponent<Button>();
        btn.onClick.AddListener(moveRight);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void moveRight()
    {
		
    }
}
