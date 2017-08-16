using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

	// Use this for initialization
    void Start()
    {

        GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameController");
        if (gameManagerObject == null)
        {
            return;
        }

        GameManager gameManager = gameManagerObject.GetComponent<GameManager>();

        Text text = GetComponent<Text>();

        text.text = "Room and Board - " + gameManager.RoomAndBoard + "Fish a day\n\n";
        text.text += "Total Fish Collected - " + gameManager.FishCollectedTotal + "\n\n";
        text.text += "Fish Collected Today - " + gameManager.FishCollectedToday + "\n\n";
        text.text += "Days so Far - " + gameManager.DaysPlayed + "\n\n";
        text.text += "\n\n";
        text.text += "Remaining Debt - " + gameManager.FishDebt + "\n\n";

    }

    // Update is called once per frame
	void Update () {
		
	}
}
