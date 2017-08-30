using UnityEngine;
using System.Collections;

public class AbramsScript : MonoBehaviour {

	public float moveSpeed = 750f;
	public float turnSpeed = 100f;

	//public object turret;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (moveSpeed * Input.GetAxis ("Vertical") * Time.deltaTime, 0f, 0f);
		if (Input.GetKey("left")) {
			print ("left");
			transform.Rotate(0f, turnSpeed* Input.GetAxis ("Horizontal") * Time.deltaTime, 0f );
		}

		if (Input.GetKey("right")) {
			print ("right");
			transform.Rotate(0f, turnSpeed* Input.GetAxis ("Horizontal") * Time.deltaTime, 0f );
		}
	}
}
