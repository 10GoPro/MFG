using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 movement = new Vector3 (Input.acceleration.x, 0.0f, Input.acceleration.y);

		if( movement != Vector3.zero) {
			GetComponent<Rigidbody>().AddForce(movement);
		}
	}
}
