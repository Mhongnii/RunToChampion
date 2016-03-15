using UnityEngine;
using System.Collections;

public class CameraAdjust : MonoBehaviour {

	public float r480_320 = 0.2f;
	public float r960_640 = 0.5f;
	// Use this for initialization
	void Start () {
		GetComponent<Camera> ().orthographicSize = 1;
	}
	
	// Update is called once per frame
	void Update () {
		//Resolution = 480 x 320 
		if(Input.GetKey(KeyCode.E))	{
			GetComponent<Camera>().orthographicSize = r480_320;
			print("480 x 320");
		}
		//Resolution = 960 x 640
		if(Input.GetKey(KeyCode.Q)) {
			GetComponent<Camera>().orthographicSize = r960_640;
			print("960 x 640");
		}

	}
}
