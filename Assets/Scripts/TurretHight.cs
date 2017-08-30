using UnityEngine;
using System.Collections;


public class TurretHight : MonoBehaviour {

	public float heightSpeed  = 20f;

	// Use this for initialization
	void Start () {
	// heightSpeed = 100f;
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("c")) {
			print ("c = up turret");

			if ((transform.eulerAngles.z < 20) || (transform.eulerAngles.z > 300)) {
				transform.Rotate (0f, 0f, heightSpeed * Time.deltaTime);
			}
//			print (GameObject.Find ("TurretPivot").transform.localEulerAngles.y);
		}
		
		if (Input.GetKey ("v")) {
			print ("v = down turret");

			float mainTurretAngle = GameObject.Find("TurretPivot").transform.localEulerAngles.y;
			if (( mainTurretAngle > 140) && ( mainTurretAngle < 220)) {
				if ((transform.eulerAngles.z < 21) || (transform.eulerAngles.z > 350)) {
					transform.Rotate (0f, 0f, -1 * heightSpeed * Time.deltaTime);
				}
			} else {
				if ((transform.eulerAngles.z < 21) || (transform.eulerAngles.z > 340)) {
					transform.Rotate (0f, 0f, -1 * heightSpeed * Time.deltaTime);
				}
			}
		}
	}
}
