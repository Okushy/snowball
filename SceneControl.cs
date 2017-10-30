using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : MonoBehaviour {
	public enum STEP
	{
		NONE = -1,
		PLAY = 0,
		GAMEOVER,
		CLEAR,
		NUM,
	};

	public STEP step = STEP.NONE;
	public STEP next_step = STEP.NONE;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
