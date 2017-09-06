using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLevel : MonoBehaviour
{
    [SerializeField] private string targetScene;
    private bool isTouched;
    

    // Use this for initialization
    void Start ()
	{

	    isTouched = false;

	}
	
	// Update is called once per frame
	void Update () {

        if (isTouched)
        {
            SceneManager.LoadScene(targetScene);

        }
		
	}

    private void OnTriggerEnter(Collider other)
    {
        isTouched = true;
    }
}
