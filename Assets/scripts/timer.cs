using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class timer : MonoBehaviour {
    public string levelToLoad;
    public float timedown = 80f;
    private Text timertext;
    private bool timerisActive = true;

	// Use this for initialization
	void Start () {
        timertext=GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (timerisActive)
        {
        timedown -= Time.deltaTime;
        timertext.text = timedown.ToString("f0");
        print(timedown);
            if (timedown <= 0)
            {
                timedown = 0;
                timerisActive = false;
                print("time's up");
            }
            }
       
        }
	}

