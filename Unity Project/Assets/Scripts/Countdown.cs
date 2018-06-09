using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    private float timeRemaining;

    public float Duration = 60;
    public bool IsCountingDown = false;
    public GameAction GameAction;
    public Text Display;
    AudioSource endLevelBuzzer;



    public void Start()
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");

        GameManager gameManager = gameController.GetComponent<GameManager>();

        if (gameManager.isSick)
        {
            Duration /= 2;
        }

        if (IsCountingDown)
        {
            StartTimer();
        }

        endLevelBuzzer = gameManager.endLevelBuzzer;
    }

    public void StartTimer()
    {
        IsCountingDown = true;
        timeRemaining = Duration;
    }

    private void Update()
    {
        if (IsCountingDown)
        {
            timeRemaining -= Time.deltaTime;

            if (timeRemaining <= 0)
            {
                endLevelBuzzer.Play();
                timeRemaining = 0;
                IsCountingDown = false;
                if (GameAction)
                {
                    GameAction.DoAction();

                }
            }

            if (Display)
            {
                Display.text = "Time Remaining: \n" + System.Math.Floor(timeRemaining);
            }
        }
    }
}