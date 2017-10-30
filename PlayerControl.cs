using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	public static float MOVE_MAX = 7.0f;
	public static float MOVE_MIN = -(MOVE_MAX);
	public static float SPEED = 15.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		is_touched ();
	}

	void is_touched(){
		float nowPos_x =this.transform.position.x;	//現在位置を保管.
		float nextPos_x = 0.0f;	//次の位置.
		float delta_x = 0.0f;	//変化量.

		if(Input.GetKey(KeyCode.RightArrow)){	//右矢印が押されたら.
			delta_x = SPEED * Time.deltaTime;	//右への変化量.
		}else if(Input.GetKey(KeyCode.LeftArrow)){	//逆.n
			delta_x = -(SPEED * Time.deltaTime);
		}
		nextPos_x = nowPos_x + delta_x;

		if (nextPos_x <= MOVE_MAX && nextPos_x >= MOVE_MIN) {	//次の移動位置が移動幅内なら.
			this.transform.Translate(new Vector3(delta_x,0.0f,0.0f));	//移動.
				}else{
			this.transform.Translate(new Vector3(0.0f,0.0f,0.0f));	//違ったら移動しない.
				}
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.CompareTag("Snowball")){
			col.gameObject.tag = "Player";
		}
	}
}
