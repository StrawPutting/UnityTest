using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Demo1/InputTest1")]
public class InputTest : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    private float speed;
    private float angleSpeed;
    void Start () {
        speed = 1;
        angleSpeed = 10f;
    }
	
	// Update is called once per frame
	void Update () {
        /*if(Input.GetButton("Fire1"))
        {
            print("button");
        }
        if (Input.GetButtonDown("Fire1"))
        {
            print("down");
        }
        if (Input.GetButtonUp("Fire1"))
        {
            print("up");
        }*/

        //transform.Translate(Vector3.right * Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * Input.GetAxisRaw("Vertical") * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Horizontal") * angleSpeed * Time.deltaTime);
    }
}
