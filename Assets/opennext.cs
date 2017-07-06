using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opennext : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ButtonOpenDemoScene1()
    {
        

        // Waits 1.5 secs for Moving Out animation then load next level
  
        Application.LoadLevel("eat_food");
     
    }

    // Open Demo Scene 2
    public void ButtonOpenDemoScene2()
    {
        

        // Waits 1.5 secs for Moving Out animation then load next level
       
        Application.LoadLevel("clean");

    }
    public void ButtonOpenDemoScene3()
    {
        // Disable all buttons
     

        // Waits 1.5 secs for Moving Out animation then load next level
        Application.LoadLevel("sleep");
       
    }
    public void ButtonOpenDemoScene4()
    {
        // Disable all buttons
      

        // Waits 1.5 secs for Moving Out animation then load next level
    
        Application.LoadLevel("hospital");
        
    }

}
