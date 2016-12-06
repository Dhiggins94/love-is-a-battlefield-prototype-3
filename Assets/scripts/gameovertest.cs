using UnityEngine;
using System.Collections;

public class gameovertest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyUp(KeyCode.G))
        {
            GetComponent<GameManger_master>().CalleventGameOver();
        }
	}

}
