using UnityEngine;
using System.Collections;

public class Riftup : MonoBehaviour {

	public GameObject dog1;
	public GameObject dog2;
	public GameObject window;
	public GameObject hands;
	int count = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			count += 1;
			hands.transform.localPosition += Vector3.up;

		}

		if (count == 20) {
			dog1.SetActive (false);
			dog2.SetActive (true);
			Debug.Log ("カウントが" + count + "になりました。");
	    }
		if (count == 40) {
			window.SetActive (true);
		}
	}

}
