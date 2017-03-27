using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float duration = 60;
    public float timeRemaining;
    public bool isCountingDown = false;
    public void Start()
    {
        if (!isCountingDown)
        {
            isCountingDown = true;
            timeRemaining = duration;
            
        }
    }

    private void Update()
    {
        if (isCountingDown) {
            timeRemaining -= Time.deltaTime;

           if (timeRemaining<= 0) {
               timeRemaining = 0;
               isCountingDown = false;
                SceneManager.LoadScene("end scence");
            }

            GetComponent<Text>().text = "Time Remaining: \n" + System.Math.Floor(timeRemaining);
        }
    }
}