using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TakeoutWindow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick_Yes(){
		Debug.Log ("YESがおされた");
		SceneManager.LoadScene ("dakko");
	}

	public void OnClick_No(){
		Debug.Log ("NOがおされた");
		SceneManager.LoadScene ("take out");

	}
}

