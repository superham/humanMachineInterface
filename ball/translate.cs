using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class translate : MonoBehaviour {


	private SteamVR_TrackedObject trackedObj1;

	private SteamVR_Controller.Device Controller
	{
		get { return SteamVR_Controller.Input((int)trackedObj1.index);}
	}

	void Awake()
	{
		trackedObj1 = GetComponent<SteamVR_TrackedObject>();
	}

	public GameObject trackedObjectVisable;
	public GameObject trackedObjectInvisable;
	public GameObject referenceObjectX;
	public GameObject firingLine;
	//use negative angle to shift right
	public int rotAngleDeg;
	Vector3 old,newV;
	float rotAngleRat;


	// Use this for initialization
	void Start () {
		Debug.Log("Starting...");
		Debug.Log("Input angle (Deg): " + rotAngleDeg);

		rotAngleRat=rotAngleDeg * Mathf.Deg2Rad;//deg to rad
		Debug.Log("Output angle (Rad): " + rotAngleRat);
	}

	// Update is called once per frame
	void Update () {
		Debug.Log("------");
		Debug.Log("Approx. FPS: " + (1.0f / Time.deltaTime) );
		old=trackedObjectInvisable.transform.position; // 'old' position

		if(trackedObjectInvisable.transform.position.x <= firingLine.transform.position.x){ // has the object NOT passed the firing line?
			trackedObjectVisable.transform.position=old; // set the tgracked object to the visable object
			Debug.Log("no transform");
			Debug.Log("------");
		}else{

			float offset = referenceObjectX.transform.position.x - firingLine.transform.position.x;
			Debug.Log("Expected offset of, 0.6. Calcualted of: " + offset);
			newV=new Vector3(old.x,old.y, (float)(old.z + (old.x-.160)*Mathf.Tan(rotAngleRat) + Mathf.Abs(offset)) - (float)1.21 );	//apply "x degree shift" to tracked object along the z plane. '0.6' is distance between
			trackedObjectVisable.transform.position=newV;

			//trackedObjectVisable.transform.position=old; // set the tgracked object to the visable object

			//check for 1st or 2nd quad
			/*if(trackedObjectInvisable.transform.position.z <= referenceObjectX.transform.position.z){ //1st quad condition
				newV=new Vector3(old.x,old.y, -1 * (float)(old.z+old.x*Mathf.Sin(rotAngleRat) + 0.6) );	//apply "x degree shift" to tracked object along the z plane
				trackedObjectVisable.transform.position=newV; //
				Debug.Log("yes transform");
				Debug.Log("------");
			}else{ //secondn quad condition
				newV=new Vector3(old.x,old.y, -1 * (float)(old.z + old.x*Mathf.Sin(rotAngleRat) + 0.6) );	//apply "x degree shift" to tracked object along the z plane
				trackedObjectVisable.transform.position=newV; //
				Debug.Log("yes transform");
				Debug.Log("------");
			}*/
		/*	newV=new Vector3(old.x,old.y, -1 * (float)(old.z+old.x*Mathf.Sin(rotAngleRat) + 0.6) );	//apply "x degree shift" to tracked object along the z plane
			trackedObjectVisable.transform.position=newV; //
			Debug.Log("yes transform");
			Debug.Log("------");*/
		}


	/*	if(trackedObjectInvisable.transform.position.x <= referenceObjectX.transform.position.x){ //if the tracker is NOT past the firing line then apply the transform
			trackedObjectVisable.transform.position = trackedObjectInvisable.transform.position;
		}else{	*/																																								 //if the tracker is NOT past the firing line then apply the transform
			/*Converting rect. coord to polar. then shifting 30deg clockwise, then shifting back to rect.*/
			/*double r = Math.Sqrt(Math.Pow( (double) trackedObjectInvisable.transform.position.z,2) + Math.Pow( (double) trackedObjectInvisable.transform.position.x,2));
			double theta = Math.Atan(trackedObjectInvisable.transform.position.x/trackedObjectInvisable.transform.position.z);
			Debug.Log("Old Angle: " + theta);
			Debug.Log("New Angle: " + (theta-rotAngleRat));
			double newZ = r * Math.Cos((theta)-rotAngleRat);
			double newX = r * Math.Sin(theta-rotAngleRat);
				if(trackedObjectInvisable.transform.position.z <= referenceObjectX.transform.position.z){	//first quad. scenerio
					trackedObjectVisable.transform.position = new Vector3( (float) newX,trackedObjectInvisable.transform.position.y, (float) newZ);
				}else{																																										  //second quad. scenerio
					trackedObjectVisable.transform.position = new Vector3( (float) newX,trackedObjectInvisable.transform.position.y, (float) -newZ);
				}
		} */


	//	if(trackedObjectInvisable.transform.position.x >= firingLine.transform.position.x){//may
			/*Used when moving between absolute coordinate system and local coord system*/
			//double horizOffset = referenceObjectX.transform.position.z;
		//	double vertOffset = referenceObjectX.transform.position.x;

		//	double z1,x1,z2,x2;

			/*this is the point which we are transforming relative to our new origin*/
		//	z1 = trackedObjectInvisable.transform.position.z - horizOffset;
		//	x1 = trackedObjectInvisable.transform.position.x - vertOffset;
		//	Debug.Log("Before ("+z1+","+x1+")");

			/*converting to polar coords.*/
		//	double r = Math.Sqrt( Math.Pow(z1,2) + Math.Pow(x1,2) );
		//	double theta = Math.Atan(x1 / z1);//keep in mind that theta is in rad.

			/*shift our position by phi degrees*/
		//	theta = theta - rotAngleRat;

			/*convert the new position above back to rect. coords.*/
		//	z2 = r * Math.Cos(theta);
		//	x2 = r * Math.Sin(theta);

			/*convert back to absolute coord. from local coord. (local to the reference object)*/
		//	z2 += horizOffset;
		//	x2 += vertOffset;
		//	Debug.Log("After ("+z1+","+x1+")");

			/*apply the new coord. to the tracked visable object*/
			//trackedObjectVisable.transform.position = new Vector3( (float) x2, (float) trackedObjectInvisable.transform.position.y, (float) z2);
	//	}else{
		//	trackedObjectVisable.transform.position = trackedObjectInvisable.transform.position;
		//}
	}
}
