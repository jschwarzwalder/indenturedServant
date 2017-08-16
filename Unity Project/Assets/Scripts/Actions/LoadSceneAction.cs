using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAction : GameAction
{

    public string targetScene;

    public override void DoAction()
    {
        GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameController");
       

        GameManager gameManager = gameManagerObject.GetComponent<GameManager>();
       // gameManager.FishCollectedToday = 

        SceneManager.LoadScene(targetScene);

    }
}
