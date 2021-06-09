using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabInsta : MonoBehaviour {

    public GameObject Hero;
    private GameObject hero;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            hero = Instantiate(Hero);
            hero.transform.position = Vector3.zero;
            hero.AddComponent<CubeMove>();
        }
        if (Input.GetMouseButtonDown(1))
        {
            CubeMove cubeMove = hero.GetComponent<CubeMove>();
            Destroy(cubeMove);
            //Destroy(hero, 2);
        }
    }
}
