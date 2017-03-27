using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VR.WSA;

public class FishSort : MonoBehaviour
{

    public int sorted_fish;
    public FishData sorted_object; 
    

	// Use this for initialization
	void Start ()
	{
	    sorted_fish = 0;

	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnTriggerEnter(Collider other)
    {
        FishData data = other.GetComponent<FishData>();
        if (data != null && data.type.Equals( sorted_object.type))
        {
            //count, set timer to destroy
            sorted_fish++;
        }
    }

    
}
