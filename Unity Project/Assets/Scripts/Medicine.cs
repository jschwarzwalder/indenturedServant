using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Medicine : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{

	    GameObject gameController = GameObject.FindGameObjectWithTag("GameController");

	    GameManager gameManager = gameController.GetComponent<GameManager>();

	    gameManager.isSick = true;



	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");

        GameManager gameManager = gameController.GetComponent<GameManager>();
        gameManager.isSick = true;

    }
}
