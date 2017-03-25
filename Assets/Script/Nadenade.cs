using UnityEngine;
using System.Collections;

public class Nadenade : MonoBehaviour {

	public GameObject hand;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		Vector3 pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		pos.z = 0;
		hand.transform.position = pos;


	}

	void OnTriggerEnter(Collider other) {
		Debug.Log("なでなで");
	}


	void OnTriggerStay(Collider other) {
		Debug.Log("なでなでしている");
	}
}
