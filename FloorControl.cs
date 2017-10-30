using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.CompareTag("Snowball")||col.gameObject.CompareTag("Ironball")){
			Destroy(col.gameObject);
		}
	}
}
