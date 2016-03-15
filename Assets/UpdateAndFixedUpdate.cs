using UnityEngine;
using System.Collections;

public class UpdateAndFixedUpdate : MonoBehaviour {

	// Use this for initialization
	void Update () {
		print ("Update time : " + Time.deltaTime);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		print ("FixedUpdate time : " + Time.deltaTime);
	}
}
