using UnityEngine;
using System.Collections;

public class DescriptionsCompiler : MonoBehaviour {
    public int current;
    public Datalogger data;
    public bool dated;
    public GameObject[] dates = new GameObject[20];
    public ArrayList yesno = new ArrayList();
	// Use this for initialization
	void Start () {
        dated = false;
        data = GameObject.Find("Datalogger").GetComponent<Datalogger>();
        for(int i = 0; i<data.matches.Count; i++)
        {
            if((bool)data.matches[i])
            {
                yesno.Add(i);
                dated = true;
            }
        }
        current = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (!dated) { GameObject.Find("Nope").SetActive(true); }
        else
        {
            for(int i = 0; i<20; i++)
            {
                dates[i].SetActive(false);
            }
            dates[(int)yesno[current]].SetActive(true);
        }
	}

    public void GoRight()
    {
        int looped = current;
        current++;
        if (current >= yesno.Count)
        {
            current = 0;
        }
    }
    
    public void GoLeft()
    {
        int looped = current;
        current--;
        if (current < 0)
        {
            current = yesno.Count-1;
        }
    }
}
