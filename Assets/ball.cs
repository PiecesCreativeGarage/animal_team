using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class ball : MonoBehaviour {

	public GameObject myball;
	public float power;

	Rigidbody rbmyball;
	Vector3 ballvec;

	Vector3 clickPosDown,clickPosup;

	// Use this for initialization
	void Start () {

		rbmyball = myball.GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {

			clickPosDown = Input.mousePosition;
		
		}

		if (Input.GetMouseButtonUp (0)) {

			clickPosup = Input.mousePosition;

		}

		if(clickPosup == clickPosDown)
		{
			return;

		}

		//llvec = (clickPosDown - clickPosup);
		//llvec.z = ballvec.y;
		//llvec.y = 0;
		//llvec.Normalize ();
		ballvec.x = 0;
		ballvec.y = 50;
		ballvec.z = 100;
		ballvec.Normalize ();

		rbmyball.AddForce (ballvec*power);

	}
}

			
			

			
	

