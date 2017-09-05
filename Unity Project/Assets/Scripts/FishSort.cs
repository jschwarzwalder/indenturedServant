using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Internal;
using UnityEngine.UI;
using UnityEngine.VR.WSA;

public class FishSort : MonoBehaviour
{
    private int sorted_fish_count;
    public int sorted_fish

    {
        get { return sorted_fish_count; }
        set
        {
            Debug.Log("Text Object = " + textObject);
            Debug.Log("Sorted Object = " + sorted_object);
            sorted_fish_count = value;
            textObject.text = sorted_object.type + "s sorted: \n" + sorted_fish_count;
        }

    }
    public FishData sorted_object;
    public Text textObject;
    public Countdown timer;
    [SerializeField] private int sorted_fish_value;

    public int fish_value
    {
        get { return sorted_fish_value;}
    }


    // Use this for initialization
    void Awake()
    {
        sorted_fish = 0;
        Debug.Log(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (!timer.IsCountingDown)
        {
            
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        FishData data = other.GetComponent<FishData>();
        if (data != null && data.type.Equals(sorted_object.type))
        {
            if (timer.IsCountingDown)
            {
                sorted_fish++;
                timeDeath fadeTheFish = other.GetComponent<timeDeath>();
                fadeTheFish.timerStarted = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FishData data = other.GetComponent<FishData>();
        if (data != null && data.type.Equals(sorted_object.type))
        {
            if (timer.IsCountingDown)
            {
                sorted_fish--;
                timeDeath fadeTheFish = other.GetComponent<timeDeath>();
                fadeTheFish.timerStarted = false;
            }

        }
    }


}
