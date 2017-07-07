using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorInfo : MonoBehaviour {
    public static int satiety; // 100 배고픔이 30이하일때 경고 10이하면 질병 0이면 죽음
    public static int cleanliness; //10 5이하일때 건강1- / 7이상일때 건강2- 10이상일때 건강 3-
    public static int health; //5 0이면죽음
    public static int disease; // 가끔발생
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //정보값들을 건네주는 함수 구현 필요
}
