using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorManager : MonoBehaviour {

    private GameObject snowObj;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    // 상태에 따라 이미지 변화하는 함수 혹은 씬을 변화
    public void createSnow()
    {
        GameObject obj = Instantiate (snowObj, Vector3.zero, Quaternion.identity) as GameObject;

        obj.transform.parent = GameObject.Find("snow").transform;
        obj.transform.localPosition = new Vector3(-7.6294e-06f, 1.5259e-05f, 0.0f);
        obj.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        
    }
}
