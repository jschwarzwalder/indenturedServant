using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int FishDebt;
    public int FishCollectedTotal;
    public int FishCollectedToday;
    public int RoomAndBoard;
    public int DaysPlayed;
    public bool isSick;


	// Use this for initialization
	void Start ()
	{
	    DontDestroyOnLoad(gameObject);
	    isSick = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //save game progress
    public void SaveData(string FurthestEndScene)
    {
        PlayerPrefs.SetInt("FishDebt", FishDebt);
        PlayerPrefs.SetInt("FishCollectedTotal", FishCollectedTotal);
        PlayerPrefs.SetInt("FishCollectedToday", FishCollectedToday);
        PlayerPrefs.SetInt("RoomAndBoard", RoomAndBoard);
        PlayerPrefs.SetInt("DaysPlayed", DaysPlayed);
        PlayerPrefs.SetString("FurthestEndScene", FurthestEndScene);
    }

    public void LoadSavedGame()
    {
        FishDebt = PlayerPrefs.GetInt("FishDebt");
        FishCollectedTotal = PlayerPrefs.GetInt("FishCollectedTotal");
        FishCollectedToday = PlayerPrefs.GetInt("FishCollectedToday");
        RoomAndBoard = PlayerPrefs.GetInt("RoomAndBoard");
        DaysPlayed = PlayerPrefs.GetInt("DaysPlayed");
        isSick = false;
        string FurthestEndScene = PlayerPrefs.GetString("FurthestEndScene");

        DontDestroyOnLoad(gameObject);

        SceneManager.LoadScene(FurthestEndScene);

    }       
}
