using System.Collections;
using System.Collections.Generic;
using NewtonVR;
using UnityEngine;


	public class MakeItRainFish : MonoBehaviour {
		public GameObject[] FishPrefab;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	//	Rigidbody rb = RocketInstance.GetComponent<Rigidbody>();
	//	rb.velocity = new Vector3(0,-10,0);
        Debug.Log("Make it Rain Script");

		int randomGen = Random.Range (0, FishPrefab.Length);
	    GameObject fish = GameObject.Instantiate(FishPrefab[randomGen], transform.position, transform.rotation);


		fish.GetComponent<Rigidbody>().isKinematic = true;
		fish.GetComponent<NVRInteractableItem>().CanAttach = false;

		Vector3 startScale = Vector3.one * 0.1f;
		Vector3 endScale = Vector3.one;

		float startTime = Time.time;
		float overTime = 0.5f;
		float stopTime = startTime + overTime;



		fish.GetComponent<Rigidbody>().isKinematic = false;
		fish.GetComponent<NVRInteractableItem>().CanAttach = true;
	}
}

