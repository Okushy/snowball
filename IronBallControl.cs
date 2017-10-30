using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IronBallControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.CompareTag ("Player")) {
			Destroy (col.gameObject);
			SceneManager.LoadScene("TitleScene");
		} else if (col.gameObject.CompareTag ("Snowball")) {
			Destroy(col.gameObject);
		}
	}
}
