using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public KeyCode moveUp;
	public KeyCode moveDown;
	public float speed = 10f;
	public Rigidbody2D rb2D;
	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D> ();
	}
	
	// The fixed update run with physics. It fires every physics update.
	void Update () {
		if(Input.GetKey(moveUp)){
			rb2D.velocity = new Vector2(0,speed);
		}else if(Input.GetKey(moveDown)){
			rb2D.velocity = new Vector2(0,speed * -1);
		}else{
			//rb2D.velocity = new Vector2(0,0);
		}
	}
}
