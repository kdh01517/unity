using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScrpt : MonoBehaviour {



	public static float maxhp = 100;
	public static float currenthp = 100;

	public Image content;



	// Use this for initialization
	void Start () 
	{
		content.fillAmount = currenthp / maxhp;
		Invoke("Hp_minus", 7);

		InvokeRepeating("Hp_minus", 14,7);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void Hp_minus()
	{
		currenthp -= 5;
		content.fillAmount = currenthp / maxhp;
	}

}
