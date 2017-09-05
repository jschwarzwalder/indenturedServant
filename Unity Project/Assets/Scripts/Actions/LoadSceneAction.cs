using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAction : GameAction
{

    public string targetScene;
    private GameObject[] bucketsObjects;

    public override void DoAction()
    {
        GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameController");
       

        GameManager gameManager = gameManagerObject.GetComponent<GameManager>();
       // gameManager.FishCollectedToday = 
       foreach (GameObject bucketObject in bucketsObjects)
       {
           FishSort bucket = bucketObject.GetComponent<FishSort>();
            gameManager.FishCollectedToday += (bucket.sorted_fish) * (bucket.fish_value);
        }

        SceneManager.LoadScene(targetScene);

    }

    private void Start()
    {
       bucketsObjects =  GameObject.FindGameObjectsWithTag("Bucket");
    }
}
