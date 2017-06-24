using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handRotate : MonoBehaviour {	
	void Update () {
		float sensitivity = 10f; // いわゆるマウス感度
		float mouse_move_x = Input.GetAxis("Mouse X") * sensitivity;
		float mouse_move_y = Input.GetAxis("Mouse Y") * sensitivity;

		transform.Rotate(new Vector3(mouse_move_y, -1 * mouse_move_x, 0));
	}
}
