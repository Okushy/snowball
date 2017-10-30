using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.CompareTag ("Player")) {
			this.gameObject.transform.parent = col.gameObject.transform;
		} else if (col.gameObject.CompareTag ("Snowball")) {
			col.gameObject.tag = "Player";
		} else if (col.gameObject.CompareTag ("Ironball")) {
			Destroy (this.gameObject);
		}
	}

}
