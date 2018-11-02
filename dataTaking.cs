using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class dataTaking : MonoBehaviour {

	public GameObject referencePt;
	Vector3 pos;
	Vector2 v1,v2,d;
	string red = "red";
	string green = "green";

	float zP,yP;
	static void WriteString(Vector2 d, string color)
	{
		string path = "Assets/data/targetContactData.txt";
		StreamWriter writer = new StreamWriter(path,true);
		if(color=="green"){
			writer.WriteLine("{0},{1},{2}",d.x,d.y,1);
			writer.Close();
		}else{
			writer.WriteLine("{0},{1},{2}",d.x,d.y,0);
			writer.Close();
		}
		//writer.WriteLine("{0},{1},{2}",d.x,d.y,color);
		//writer.Close();
		//Debug.Log(d.x+1.529f);
		/*
		this offset makes the invistable perturbed ball collision correct

		*/
	//Debug.Log(yPos);
	}
  void breakLine()
	{
		string path = "Assets/data/targetContactData.txt";
		StreamWriter writer = new StreamWriter(path,true);
		writer.WriteLine("___________________________________________");
	//	writer.WriteLine("################# NEW DATA ################");
	//	writer.WriteLine("{0},{1}",v1.x,v1.y);
	//	writer.Close();
	}

	void Start(){
		v1= new Vector2(referencePt.transform.position.z,referencePt.transform.position.x);
		breakLine();
	}

	void OnCollisionEnter(Collision collision)
	{
			ContactPoint contact = collision.contacts[0];
			if(collision.gameObject.name=="Green Ball Inv"){
				pos = contact.point;
				pos.z-=1.529f;//THIS IS ONLY GOOD FOR X=3.258 AND THETA=-30
				pos.y-=2.233f;//this if from the targets reported verticle position
				v2=new Vector2(pos.z,pos.y);
				//Vector2.Distance(v1,v2);
				//d=new Vector2(v2.x-v1.x,v2.y-v1.y);
			//	zP=referencePt.transform.position.z - pos.z;
			//	yP=referencePt.transform.position.y - pos.y;
				WriteString(v2,green);
			}
			if(collision.gameObject.name=="RedBall"){
				pos = contact.point;
				//pos.z-=1.529f;//THIS IS ONLY GOOD FOR X=3.258 AND THETA=-30
				pos.y-=2.233f;//this if from the targets reported verticle position
				v2=new Vector2(pos.z,pos.y);
				//Vector2.Distance(v1,v2);
			//	d=new Vector2(v2.x-v1.x,v2.y-v1.y);
				//zP=pos.z - referencePt.transform.position.z;
				//yP=pos.y - referencePt.transform.position.y;
				WriteString(v2,red);
			}

	}

}
