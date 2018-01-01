using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoSavedGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //if player has no saved game data
        if (!PlayerPrefs.HasKey("FurthestEndScene") ){
            gameObject.GetComponent<Button>().interactable = false;

        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
