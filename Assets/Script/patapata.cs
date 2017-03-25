using UnityEngine;
using System.Collections;

public class patapata : MonoBehaviour {

	public SpriteRenderer target;
	public Sprite picture;


	public Sprite picture2;

	int flag = 0;
	public int count = 0;
	public int countMax = 60;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		count += 1;
		if (count == 1) {
			if (flag == 0) {
				target.sprite = picture;
				flag = 1;
			} else {
				target.sprite = picture2;
				flag = 0;
			}

		}
		else if (count > countMax) {
			count = 0;
		}
	}
}
