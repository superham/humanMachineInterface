using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetCube : MonoBehaviour {

	public GameObject  ballToReset;
	public GameObject originPt;
	public Rigidbody rb;
	Vector3 position;
	void Start(){
		position=originPt.transform.position;
		rb = ballToReset.GetComponent<Rigidbody>();
	//	Debug.Log("resetCub.cs start function called.");
	}

	void OnCollisionEnter (Collision col)
	{
	//
			if(col.gameObject.name == "Green Ball Inv" || col.gameObject.name=="RedBall")
			{
			//	Debug.Log("Ball was reset.");
				ballToReset.transform.position=position;
				rb.velocity = Vector3.zero;
				rb.angularVelocity = Vector3.zero;
			}
	}
}
