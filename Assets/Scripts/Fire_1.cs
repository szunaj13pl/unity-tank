using UnityEngine;
using System.Collections;

public class Fire_1 : MonoBehaviour {

	public Rigidbody projectile;
	
	public float speed = 1000f;
	//GameObject Abrams = new GameObject.Find("Abrams2");
			public Animation anim;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetButtonDown("Fire1"))
		{
			if (!anim.isPlaying) {
				anim.Play();
			}
			//Abrams.Animation.Play(Fire_1_anim);
			
			//anim.Play(Fire_1);

			Rigidbody instantiatedProjectile = Instantiate(projectile,
			                                               transform.position,
			                                               transform.rotation)
				as Rigidbody;
			
			instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,speed));
			
		}
	}
}