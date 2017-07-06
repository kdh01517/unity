using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s1_script : MonoBehaviour {

    public float delayTime = 1;
	// Use this for initialization
	IEnumerator Start () {
        yield return new WaitForSeconds(delayTime);

        Application.LoadLevel("s2");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
