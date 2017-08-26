using UnityEngine;
using System.Collections;

public class PrefabInstancer : MonoBehaviour {

    public GameObject _prefab;
    public GameObject _PrefabOut;
    public float _CountUp;

	// Use this for initialization
	void Start ()
    {
        _CountUp = 0.0f;
    }

    public void _MusicBtn()
        {
        
             var _Go = (GameObject)Instantiate(_prefab, _PrefabOut.transform.position, Quaternion.Euler(90, 0, 0));
            _Go.transform.parent = _PrefabOut.transform;
            _Go.name = "AA";
            _CountUp = 0;

        }
	
	// Update is called once per frame
	void Update ()
    {

        //_CountUp += 0.1f;

        //if (_CountUp > 1.0f)
        //{
        //    var _Go = (GameObject)Instantiate(_prefab, _PrefabOut.transform.position, Quaternion.Euler(90, 0, 0));
        //    _Go.transform.parent = _PrefabOut.transform;
        //    _Go.name = "AA";
        //    _CountUp = 0;
        //}
    }
}
