using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactorInfo : MonoBehaviour {
	// public static int satiety; // 100 배고픔이 30이하일때 경고 10이하면 병걸림 // 아이템 게임하면 1개씩
	public static int cleanliness; //10 5이하일때 건강1- / 7이상일때 건강2- 10이상일때 건강 3- 병걸림  공짜
	public static int health; //5 0이면죽음 블루투스로 주고받기
	public static int disease; //1/0 가끔발생  지속적으로 떨어짐
	public static int exp;
	public static int level;
	//public static float sleep; //
	public static float maxhp = 100;
	public static float currenthp = 100;
	public static float maxtired = 100;
	public static float currenttired = 100;
	public static int max_exp = 10; // 10이 넘으면 0으로 바뀌고 레벨 1단계 올림
	public static int max_level = 50; // 레벨이 오를때마다 형태가 변화 25 50
	public Image content;
	public  GameObject ddong;
	public  Image content2; 
	public static int count = 0;
	public GameObject cure;
	public GameObject diseases;


	// Use this for initialization
	void Start()
	{
		content.fillAmount = currenttired / maxtired;
		Invoke("tired_minus", 7);

		InvokeRepeating("tired_minus", 14, 7);

		content.fillAmount = currenthp / maxhp;
		Invoke("Hp_minus", 7);

		InvokeRepeating("Hp_minus", 14, 7);

		InvokeRepeating ("random_ddong", 1, 1);

		InvokeRepeating ("random_disease", 3, 3);
		/*if (ddong.activeSelf == true) {
			ddong.SetActive (true);
		}
		while (count > 0) {
			ddong.SetActive (true);
			content2.fillAmount = 0;
			count--;
		}*/

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void Hp_minus()
	{
		currenthp -= 5;
		content.fillAmount = currenthp / maxhp;
	}

	public void tired_minus()
	{
		currenttired -= 5;
		content.fillAmount = currenttired / maxtired;
	}

	public void random_ddong(){

		int ran = Random.Range (1, 10);
		if (ran == 3) {
			ddong.SetActive (true);
			count++;
			content2.fillAmount = 0;

		}
	}

	public void random_disease(){
		int ran2 = Random.Range (1, 10);
		if (ran2 == 3) {
			diseases.SetActive (true);
			cure.SetActive (false);
		}
	}


}
