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
        if(image1.activeSelf == true)
        {
            image1.SetActive(false);
            image2.SetActive(true);
        }
        else if(image2.activeSelf == true)
        {
            image2.SetActive(false);
            image3.SetActive(true);
        }
    }
}
