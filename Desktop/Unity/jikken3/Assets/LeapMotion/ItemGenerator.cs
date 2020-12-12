using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemGenerator : MonoBehaviour 
{
	public GameObject cubePrefab;
	public GameObject spherePrefab;
	float span = 1.0f;
	float delta = 0;
	int ratio = 2;

	//public Text Scoretext;
	//private int score = 0;

	//void OnTriggerEnter(Collider other)
	//{
		//Score += 10;
		//Scoretext.text = string.Format("Score:{0}", score);
	//}


	// Update is called once per frame
	void Update () 
	{
		this.delta += Time.deltaTime;
		if(this.delta > this.span)
		{
			this.delta = 0;
			GameObject item;
			int dice = Random.Range(1,11);
			if(dice <= this.ratio)
			{
				item = Instantiate(cubePrefab) as GameObject;
			}
			else
			{
				item = Instantiate(spherePrefab) as GameObject;
			}
			float x = Random.Range(-5,5);
			float z = Random.Range(3,8);
			item.transform.position = new Vector3(x, 4, z);
		}
	}
}
