using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class handRotate : MonoBehaviour {	
	private float _sensitivity;
	private Vector3 _mouseReference;
	private Vector3 _mouseOffset;
	private Vector3 _rotation;
	private bool _isRotating;

	void Start() {
		_sensitivity = 0.4f;
		_rotation = Vector3.zero;
		Debug.Log (transform.rotation);
	}
	void Update () {
//		if (Input.GetMouseButtonDown (0)) {
//			Debug.Log ("Clicked");
//			Vector3 clickDeltaPosition = Input.mousePosition;
//			Debug.Log (clickDeltaPosition);
//			Debug.Log (transform.position);
//////		float sensitivity = 10f; // いわゆるマウス感度
//////		float mouse_move_x = Input.GetAxis("Mouse X") * sensitivity;
//////		float mouse_move_y = Input.GetAxis("Mouse Y") * sensitivity;
//////			transform.rotation = new Quaternion(clickDeltaPosition[0], clickDeltaPosition[1], 0, 0);
//////			transform.Rotate (new Vector3 (clickDeltaPosition[0], clickDeltaPosition[1], 0));
//			transform.LookAt(clickDeltaPosition[0], clickDeltaPosition[1], 0);]
//			transform.LookAt(10, 20);
//			var diff = (clickDeltaPosition - transform.position).normalized;
//			transform.rotation = Quaternion.FromToRotation (Vector3.up, );
		if(_isRotating)
		{
			_mouseOffset = (Input.mousePosition - _mouseReference);	
			_rotation.y = -(_mouseOffset.x + _mouseOffset.y) * _sensitivity;
			transform.Rotate (_rotation);
			_mouseReference = Input.mousePosition;
		}
	}

	void OnMouseDown (){
		_isRotating = true;
		_mouseReference = Input.mousePosition;
	}

	void OnMouseUp()
	{
		_isRotating = false;
	}

}
