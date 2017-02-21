using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewtonVR.Example
{
	public class MakeItRainFish : MonoBehaviour {
		public GameObject RocketPrefab0;
		public GameObject RocketPrefab1;
		public GameObject RocketPrefab2;
		public GameObject RocketPrefab3;
		private GameObject RocketInstance;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	//	Rigidbody rb = RocketInstance.GetComponent<Rigidbody>();
	//	rb.velocity = new Vector3(0,-10,0);

		int randomGen = Random.Range (1, 5);


		if  (randomGen == 1) {
			RocketInstance = (GameObject)GameObject.Instantiate(RocketPrefab0, this.transform.position, this.transform.rotation);
		}
		else if  (randomGen == 2)  {
			RocketInstance = (GameObject)GameObject.Instantiate(RocketPrefab1, this.transform.position, this.transform.rotation);
		}
		else if  (randomGen == 3)  {
			RocketInstance = (GameObject)GameObject.Instantiate(RocketPrefab2, this.transform.position, this.transform.rotation);
		}
		else {
			RocketInstance = (GameObject)GameObject.Instantiate(RocketPrefab0, this.transform.position, this.transform.rotation);
		}
		RocketInstance.GetComponent<Rigidbody>().isKinematic = true;
		RocketInstance.GetComponent<NVRInteractableItem>().CanAttach = false;

		Vector3 startScale = Vector3.one * 0.1f;
		Vector3 endScale = Vector3.one;

		float startTime = Time.time;
		float overTime = 0.5f;
		float stopTime = startTime + overTime;



		RocketInstance.GetComponent<Rigidbody>().isKinematic = false;
		RocketInstance.GetComponent<NVRInteractableItem>().CanAttach = true;
	}
}
}
