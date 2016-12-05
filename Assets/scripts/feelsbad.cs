using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class feelsbad: MonoBehaviour {

    public int playerHealth = 30;
    int damage = 10;

	// Use this for initialization
	void Start () {
        print(playerHealth);
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision _collision) {
	if (_collision.gameObject.tag == "enemy")
        {
            playerHealth -= damage;
            if (playerHealth == 0)
            {
                gameOver();
            }
            print("i've been touched" + playerHealth);
            }
        }

    void gameOver()
    {
        if (Input.GetKeyDown(KeyCode.R))
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("its over isnt it");
    }
	}

