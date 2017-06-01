using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
	// 自分のスコア
	public int myScore = 0;
	private int S_StarScore = 10;
	private int L_StarScore = 20;
	private int S_CloudScore = 5;
	private int L_CloudScore = 8;
     private GameObject scoreText;
     private Text text;
        
	// Use this for initialization
	void Start () {
            //シーン中のScoreTextオブジェクトを取得
            this.scoreText = GameObject.Find("ScoreText");
            text = this.scoreText.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
			//ScoreTextに表示
            text.text = "SCORE : " + this.myScore;
	}
	
	//衝突時に呼ばれる関数
	void OnCollisionEnter(Collision other) {
		//Debug.Log("OnCollisionEnter") ;
		AddScore(other.gameObject.tag); 
	}
	
	void AddScore(string tag) {
		 int addScore = 0;
			if (tag == "SmallStarTag") {
				addScore = this.S_StarScore;
			}else if (tag == "LargeStarTag") {
				addScore = this.L_StarScore;
			}else if(tag == "SmallCloudTag") {
				addScore = this.S_CloudScore;
			}else if(tag == "LargeCloudTag") {
				addScore = this.L_CloudScore;
			}            
			if(addScore > 0) {
				Debug.Log("Before Score  [" + this.myScore + "]" ) ;
				Debug.Log("Addscore  [" + addScore  + "]"+ "TAG : " + tag) ;
				this.myScore += addScore ;
				Debug.Log("AfterScore  [" + this.myScore + "]" ) ;
			}
	}
	
}
