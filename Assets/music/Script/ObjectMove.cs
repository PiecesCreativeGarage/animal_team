using UnityEngine;
using System.Collections;

public class ObjectMove : MonoBehaviour {

    private Vector3 _ThisPos;
    public Vector3 _MoveObject;
    public bool _des;

	// Use this for initialization
	void Start ()
    {
        _ThisPos =  this.gameObject.GetComponent<Transform>().position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.transform.localPosition += _MoveObject; 
	}

    void OnCollisionEnter(Collision col)
    {
        if(_des == true)
        { 
        Destroy(col.gameObject);
        }
    }
}
