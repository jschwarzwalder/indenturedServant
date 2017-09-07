using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");

        GameManager gameManager = gameController.GetComponent<GameManager>();

        gameManager.isSick = false;

        gameManager.RoomAndBoard = 75;


    }

    // Update is called once per frame
        void Update () {
		
	}
}
