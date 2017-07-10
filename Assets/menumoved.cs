using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menumoved : MonoBehaviour {

	void Start(){
	}

	void Update(){
	}

	public void ChangeSceneStart()
    {
        SceneManager.LoadScene("eating");
    }
}
