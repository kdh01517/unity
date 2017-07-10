using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class eat_bar_plus : CharactorInfo {



	//public Image content;
	// Use this for initialization
	void Start () {
		//con = bar.content;
		//Invoke("Hp_minus", 3);

		//InvokeRepeating("Hp_minus", 6,3);
	}
	
	// Update is called once per frame

	public void button(){
		
		currenthp += 10;
		content.fillAmount = currenthp / maxhp;
	}
}
