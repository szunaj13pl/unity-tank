using UnityEngine;
using System.Collections;

public class TurretRotacion : MonoBehaviour{
	public float rotacionSpeed;
	public float turnSpeed = 100f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		float mainTurretAngle = GameObject.Find ("TurretPivot").transform.localEulerAngles.y;
		float turretAngle_z = GameObject.Find ("CannonPivot").transform.localEulerAngles.z;
		float turretAngle_x = GameObject.Find ("CannonPivot").transform.localEulerAngles.x;
		float turretAngle_y = GameObject.Find ("CannonPivot").transform.localEulerAngles.y;

		if (Input.GetKey ("o")) {
		//	GameObject.Find("CannonPivot").transform.localPosition.Set (300f, 100f, 350f);
			print ("o = set turret");
			print(turretAngle_x +"x "+ turretAngle_y +"y "+ turretAngle_z +"z");
		}

		if (Input.GetKey ("z")) {
			print ("z = left turret");

			transform.Rotate (0f, -1 * turnSpeed * Time.deltaTime, 0f);
			if ((mainTurretAngle > 140f) && (mainTurretAngle < 220f)) {
				if (turretAngle_z > 22f) {
					if(turretAngle_z < 350f){
						print (turretAngle_x + "x " + turretAngle_y + "y " + turretAngle_z + "z");
						Vector3 newPos = new Vector3 (turretAngle_x, turretAngle_y, 350f);
						GameObject.Find ("CannonPivot").transform.localEulerAngles = newPos;
					}
				}
			}
		}
		
			if (Input.GetKey ("x")) {
			print ("x = right turret");
			transform.Rotate (0f, turnSpeed * Time.deltaTime, 0f);
			
			if ((mainTurretAngle > 140f) && (mainTurretAngle < 220f)) {
				if (turretAngle_z > 22f) {
					if(turretAngle_z < 350f){
						print (turretAngle_x + "x " + turretAngle_y + "y " + turretAngle_z + "z");
						Vector3 newPos = new Vector3 (turretAngle_x, turretAngle_y, 350f);
						GameObject.Find ("CannonPivot").transform.localEulerAngles = newPos;
					}
				}
			}
		}
	}
}

