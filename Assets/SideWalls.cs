using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour {

	public float forceX;
	public float forceY;

	static int playerScore01 = 0 ;
	static int playerScore02 = 0 ;
	// Use this for initialization
	void OnTriggerEnter2D (Collider2D hitInfo){
		Score (hitInfo.name); 
		GetComponents<AudioSource>()[1].Play () ;
	}
	
	// Update is called once per frame
	void Score (string wallName) {
		if (wallName == "rightWall") {
			playerScore01 += 1;
			BallControl ballControlScript = GetComponent<BallControl>();
			ballControlScript.ResetBall();

		} else if (wallName == "leftWall"){
			playerScore02 += 1;
			BallControl ballControlScript = GetComponent<BallControl>();
			ballControlScript.ResetBall();

		}
	}
	public GUISkin mySkin ;
	void OnGUI (){
		GUI.skin = mySkin;
		GUI.Label (new Rect (Screen.width / 2 - 150, 20, 100, 100), "" + playerScore01);
		GUI.Label (new Rect (Screen.width / 2 + 150, 20, 100, 100), "" + playerScore02);

		if (GUI.Button (new Rect (Screen.width / 2 - 60, 30, 121, 53), "RESET")) {
			playerScore01 = 0;
			playerScore02 = 0;

			GetComponents<AudioSource>()[2].Play () ;

			GameObject ballGameObject = GameObject.Find ("Ball");
			BallControl ballControlScript = ballGameObject.GetComponent<BallControl>();
			ballControlScript.ResetBall();

		}
	}

}



