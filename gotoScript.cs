using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gotoScript : MonoBehaviour {

	public GameObject originPoint;
	public GameObject objToMove;

	Vector3 originpt;

	void SetUp() {

	}

	void Update () {
		originpt=originPoint.transform.position;
		if(Input.GetKeyDown(KeyCode.Space)){
			objToMove.transform.position=originpt;
			Debug.Log("Space key was pressed.");
		}
	}
}
