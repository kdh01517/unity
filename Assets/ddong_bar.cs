using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ddong_bar : MonoBehaviour {

	public  GameObject ddong;
	// Use this for initialization
	public  Image content2;
	public static int count = 0;
	//public static float max_ddong = 100;
	//public static float current_ddong=100;

	void Start () {
		InvokeRepeating ("random_ddong", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void random_ddong(){

		int ran = Random.Range (1, 10);
		if (ran == 3) {
			ddong.SetActive (true);
			count++;
			content2.fillAmount = 0;

		}
	}
}
