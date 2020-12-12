using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour 
{
	GameObject timerText;
	GameObject scoreText;

	float time = 30.0f;
	int score = 0;

	public void ClashBullet()
	{
		this.score += 100;
	}

	public void ClashSword()
	{
		this.score += 100;
	}

	// Use this for initialization
	void Start () 
	{
		this.timerText = GameObject.Find("Time");
		this.scoreText = GameObject.Find("Score");
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.time -= Time.deltaTime;
		this.timerText.GetComponent<Text>().text = this.time.ToString("F1");
		this.scoreText.GetComponent<Text>().text = this.score.ToString() + "score";
	}
}
