using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        //Listen for key press

               
        //if 1-9 go to fish sorting level 1 to 9 or 0 will go to level 10
        if (Input.GetKeyDown("1")) {
            SceneManager.LoadScene("Level 1");
        }

        else if (Input.GetKeyDown("2"))
        {
            SceneManager.LoadScene("Level 2");
        }

        else if (Input.GetKeyDown("3"))
        {
            SceneManager.LoadScene("Level 3");
        }

        else if (Input.GetKeyDown("4"))
        {
            SceneManager.LoadScene("Level 4");
        }

        else if (Input.GetKeyDown("5"))
        {
            SceneManager.LoadScene("Level 5");
        }

        else if (Input.GetKeyDown("6"))
        {
            SceneManager.LoadScene("Level 6");
        }

        else if (Input.GetKeyDown("7"))
        {
            SceneManager.LoadScene("Level 7");
        }

        else if (Input.GetKeyDown("8"))
        {
            SceneManager.LoadScene("Level 8");
        }

        else if (Input.GetKeyDown("9"))
        {
            SceneManager.LoadScene("Level 9");
        }

        else if (Input.GetKeyDown("0"))
        {
            SceneManager.LoadScene("Level 10");
        }

    }

}

