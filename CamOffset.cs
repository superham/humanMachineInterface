using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamOffset : MonoBehaviour {
	private Vector3 altPos;
	private Vector3 trackedPos;
	public Quaternion rotation = Quaternion.identity;
	// Use this for initialization
	void Start () {
		trackedPos=transform.position;
	}

	// Update is called once per frame
	void Update () {
		trackedPos=transform.position;
		rotation.eulerAngles=new Vector3(0,30,0);
		Debug.Log("Tracked Position = "+ trackedPos);
		Debug.Log("Traked Rotation = " + rotation.eulerAngles.y);
		//altPos=transform.Rotate(Vector3.right);
	//	Debug.Log("Alterted  Position = " + altPos);
	}
}
