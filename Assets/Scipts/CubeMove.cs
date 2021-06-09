 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour {

    private float speed;
	// Use this for initialization
	void Start () {
        speed = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
}
