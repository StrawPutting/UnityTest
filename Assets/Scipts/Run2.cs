using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run2 : MonoBehaviour {
    private Animation animation;
	// Use this for initialization
	void Start () {
        animation = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxisRaw("Vertical") != 0)
        {
            //animation.Play("Run");
            animation.CrossFade("Run");
        }
        else
        {
            animation.CrossFade("Run1");
        }
	}
}
