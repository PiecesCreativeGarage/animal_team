using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MusicUIErrorArea : MonoBehaviour {

    public Text _Score;
    private int _CountUP;


    void Start()
    {
       //_ThisPos = this.gameObject.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        _Score.text = "Score:" + _CountUP;
    }
    
    //
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "AA")
        {
            Destroy(col.gameObject);
            _CountUP += 10;
            _Score.text = "Score:" + _CountUP;

        }
    }

}
