using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cleaning : CharactorInfo {

	//public GameObject ddong;
	//public GameObject ddong2;
	//Random ran = new Random();


	// Use this for initialization
	void Start () {
		while (count > 0) {
			ddong.SetActive (true);
			content2.fillAmount = 0;
			count--;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void button_on(){
		
		if (ddong.activeSelf == true ) {
			ddong.SetActive (false);
			content2.fillAmount = 1;
		} /*else if (ddong2.activeSelf == true ) {

			ddong2.SetActive (false);
		}*/

		
	}

		
}
