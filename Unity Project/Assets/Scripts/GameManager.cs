using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int FishDebt;
    public int FishCollectedTotal;
    public int FishCollectedToday;
    public int RoomAndBoard;
    public int DaysPlayed;


	// Use this for initialization
	void Start ()
	{
	    DontDestroyOnLoad(gameObject);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
