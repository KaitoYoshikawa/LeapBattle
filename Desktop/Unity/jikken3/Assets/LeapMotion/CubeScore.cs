using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScore : MonoBehaviour 
{
	GameObject director;

	// Use this for initialization
	void Start () 
	{
		this.director = GameObject.Find("GameDirector");
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag =="Bullet")
		{
			this.director.GetComponent<GameDirector>().ClashBullet();
			Debug.Log("mimi");
			Destroy(this.gameObject);
			Destroy(other.gameObject);
		}
		
	}
}
