using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NewtonVR;

public class GameLaunchButton : MonoBehaviour {

    public NVRCanvasInput Player;
    public Button StartButton;
    public Button ContinueButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void isPushed()
    {
        // //turn off laser pointer
        // Player.LaserEnabled = false;

        //hide buttons
        StartButton.gameObject.SetActive(false);
        ContinueButton.gameObject.SetActive(false);


    }
}
