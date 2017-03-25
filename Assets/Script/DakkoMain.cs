using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DakkoMain : MonoBehaviour {

	public Image fade;

	int count = 0;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		count += 1;

		Color color = fade.color;
		if (count > 60) {
			color.a += 0.005555556f;
			fade.color = color;
			Debug.Log ("aaa");
		}
		if(color.a > 1){
			SceneManager.LoadScene ("house");
		}
	}
}
