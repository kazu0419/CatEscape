using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// フレームごとに等速で落下させる
		transform.Translate(0, -0.1f, 0);
		
		// 画面外に出たら、オブジェクトを破壊する
		if(transform.position.y < -5.0f){
			Destroy(gameObject);
		}
	}
}
