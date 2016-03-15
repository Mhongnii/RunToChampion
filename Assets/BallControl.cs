using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	public float forceX = 40f ;
	public float forceY = -5f ;

	void Start(){
		StartCoroutine (DelayBall());
	}

	void GoBall () {
		int randomNumber = Random.Range (0, 4);

		switch (randomNumber) {
		case 0 :
			forceX = 40f;
			forceY = -5f;
			break ;
		case 1 :
			forceX = -40f;
			forceY = 5f;
			break ;
		case 2 :
			forceX = -40f;
			forceY = -5f;
			break ;
		case 3 :
			forceX = 40f;
			forceY = 5f;
			break ;
		}
		float speed = Random.Range (1, 4);
		Vector2 force = new Vector2 (forceX * speed , forceY * speed);
		GetComponent<Rigidbody2D> ().AddForce (force);
	}
	
	void OnCollisionExit2D(Collision2D colInfo){
		if (colInfo.collider.tag == "Player"){
			Rigidbody2D ballRb = GetComponent<Rigidbody2D>();
			Vector2 ballVelocity = ballRb.velocity;

			Rigidbody2D playerRb = colInfo.collider.GetComponent<Rigidbody2D>();
			Vector2 playerVelocity = playerRb.velocity;

			float newBallVelocityY = ballVelocity.y / 2 + playerVelocity.y / 3;

			ballRb.velocity = new Vector2(ballVelocity.x, newBallVelocityY);
		}
		GetComponents<AudioSource>()[0].Play ();
		GetComponents<AudioSource>()[0].pitch = Random.Range(1,3);
	}
	public void ResetBall (){
		Rigidbody2D ballRb = GetComponent<Rigidbody2D> ();
		ballRb.velocity = new Vector2 (0, 0);

		transform.position = new Vector2 (0, 0);
		StartCoroutine (DelayBall ());
	}
	IEnumerator DelayBall(){
		yield return new WaitForSeconds(2);
		GoBall();
	}

}