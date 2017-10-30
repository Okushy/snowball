using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour {
	public float MAX_X = PlayerControl.MOVE_MAX;	//右端.
	public float MIN_X = PlayerControl.MOVE_MIN;	//左端.
	public GameObject SnowballPrefab;	//ボールを格納するプレハブ.
	public GameObject IronballPrefab;
	public float CREATE_SNOW_TIME = 500.0f;	//スノーボールを生成する間隔.
	public float CREATE_IRON_TIME = 3000.0f;	//鉄球を生成する間隔.

	private struct Ball{
		public bool snow;
		public bool iron;
		public float timer;
		public Vector3 pos;
	};

	private Ball snow_ball;
	private Ball iron_ball;

	// Use this for initialization
	void Start () {
		snow_ball.snow = true;
		iron_ball.iron = true;
	}

	// Update is called once per frame
	void Update () {
		snow_ball.timer+= Time.deltaTime;
		iron_ball.timer += Time.deltaTime;
		createBall (snow_ball);
		createBall (iron_ball);
	}

	public void createSnowBall(Vector3 ball_position){
		//ボールを作成してgoに保管.
		GameObject go = GameObject.Instantiate(this.SnowballPrefab) as GameObject;

		go.transform.position = ball_position;	//ボールの位置を移動.
	}

	public void createIronBall(Vector3 ball_position){
		//ボールを作成してgoに保管.
		GameObject go = GameObject.Instantiate(this.IronballPrefab) as GameObject;

		go.transform.position = ball_position;	//ボールの位置を移動.
	}

	public Vector3 mapBall(){
		float pos_x = Random.Range (MIN_X,MAX_X);
		Vector3 pos = new Vector3(pos_x,30.0f,0.0f);
		return pos;
	}


	void createBall(Ball ball){
		if (ball.snow) {
			if (ball.timer > CREATE_SNOW_TIME * Time.deltaTime) {
				ball.pos = mapBall ();
				createSnowBall (ball.pos);
				snow_ball.timer = 0.0f;
			}
		} else if (ball.iron) {
			Debug.Log ("First");
			if (ball.timer > CREATE_IRON_TIME * Time.deltaTime) {
				ball.pos = mapBall ();
				createIronBall (ball.pos);
				iron_ball.timer = 0.0f;
			}
		}
	}

	void timeZero(Ball ball){
		ball.timer = 0.0f;
	}
}
