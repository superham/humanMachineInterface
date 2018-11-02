using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targtMarker : MonoBehaviour {

	public GameObject markerPointRed;
	public GameObject markerPointGreen;
	Vector3 pos;
	// Update is called once per frame
	void OnCollisionEnter(Collision collision){
	//	Debug.Log("Detected a collision with target.");
		ContactPoint contact = collision.contacts[0];
		if(collision.gameObject.name == "Green Ball Inv"){
		//	Debug.Log("Collision with Inv ball detected.");
			pos = contact.point;
			pos.z -=1.406f;//1.529f; //THIS IS ONLY GOOD FOR X=3.258 AND THETA=-30
			//2.27
			//3.943
			//Debug.Log("Transforming markerPoint.");
			markerPointGreen.transform.position=pos;
		}
		if(collision.gameObject.name == "RedBall"){
			pos = contact.point;
			markerPointRed.transform.position=pos;
		}
	}
}
