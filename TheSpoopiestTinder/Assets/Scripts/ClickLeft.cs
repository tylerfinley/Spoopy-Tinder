using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickLeft : MonoBehaviour
{
    public Button leftPic;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;

    // Use this for initialization
    void Start()
    {
        Button btn = leftPic.GetComponent<Button>();
        btn.onClick.AddListener(moveRight);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void moveRight()
    {
        if (image3.activeSelf == true)
        {
            image3.SetActive(false);
            image2.SetActive(true);
        }
        else if (image2.activeSelf == true)
        {
            image2.SetActive(false);
            image1.SetActive(true);
        }
    }
}