using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectioninfo : MonoBehaviour {
    public GameObject o_q;
    public GameObject o_w;
    public GameObject o_e;
    public GameObject o_r;
    public GameObject o_t;
    public GameObject w_q;
    public GameObject w_w;
    public GameObject w_e;
    public GameObject w_r;
    public GameObject w_t;
    public GameObject t_q;
    public GameObject t_w;
    public GameObject t_e;
    public GameObject t_r;
    public GameObject t_t;
    public GameObject f_q;
    public GameObject f_w;
    public GameObject f_e;
    public GameObject f_r;
    public GameObject f_t;
    public GameObject bat_q;
    public GameObject bat_w;
    public GameObject bat_e;
    public GameObject bat_r;
    public GameObject bat_t;
    public GameObject gst_q;
    public GameObject gst_w;
    public GameObject gst_e;
    public GameObject gst_r;
    public GameObject gst_t;
    public GameObject rbt_q;
    public GameObject rbt_w;
    public GameObject rbt_e;
    public GameObject rbt_r;
    public GameObject rbt_t;
    public GameObject sli_q;
    public GameObject sli_w;
    public GameObject sli_e;
    public GameObject sli_r;
    public GameObject sli_t;

    public static int[] collection = new int[19]; // 0~4 bat, 5~9 ghost 10~14 rabbit 15~19 slime
                                                  // Use this for initialization
    void Start()
    {
        //o_q.SetActive(true);
       // bat_q.SetActive(true);
       
    }

    
        
	public void refresh()
    {
        //o_q.SetActive(true);
        // bat_q.SetActive(true);
        for (int i = 0; i < 19; i++)
        {
            if (collection[i] == 1)
            {
                if (i < 5)
                {
                    switch (i)
                    {
                        case 0:
                            o_q.SetActive(true);
                            bat_q.SetActive(true);
                            break;
                        case 1:
                            o_w.SetActive(true);
                            bat_w.SetActive(true);
                            break;
                        case 2:
                            o_e.SetActive(true);
                            bat_e.SetActive(true);
                            break;
                        case 3:
                            o_r.SetActive(true);
                            bat_r.SetActive(true);
                            break;
                        case 4:
                            o_t.SetActive(true);
                            bat_t.SetActive(true);
                            break;

                    }
                }
                else if (i > 4 && i < 10)
                {
                    i -= 5;
                    switch (i)
                    {
                        case 0:
                            w_q.SetActive(true);
                            gst_q.SetActive(true);
                            break;
                        case 1:
                            w_w.SetActive(true);
                            gst_w.SetActive(true);
                            break;
                        case 2:
                            w_e.SetActive(true);
                            gst_e.SetActive(true);
                            break;
                        case 3:
                            w_r.SetActive(true);
                            gst_r.SetActive(true);
                            break;
                        case 4:
                            w_t.SetActive(true);
                            gst_t.SetActive(true);
                            break;

                    }
                }
                else if (i > 9 && i < 15)
                {
                    i -= 10;
                    switch (i)
                    {

                        case 0:
                            t_q.SetActive(true);
                            rbt_q.SetActive(true);
                            break;
                        case 1:
                            t_w.SetActive(true);
                            rbt_w.SetActive(true);
                            break;
                        case 2:
                            t_e.SetActive(true);
                            rbt_e.SetActive(true);
                            break;
                        case 3:
                            t_r.SetActive(true);
                            rbt_r.SetActive(true);
                            break;
                        case 4:
                            t_t.SetActive(true);
                            rbt_t.SetActive(true);
                            break;

                    }
                }
                else if (i > 14 && i < 20)
                {
                    i -= 15;
                    switch (i)
                    {
                        case 0:
                            f_q.SetActive(true);
                            sli_q.SetActive(true);
                            break;
                        case 1:
                            f_w.SetActive(true);
                            sli_w.SetActive(true);
                            break;
                        case 2:
                            f_e.SetActive(true);
                            sli_e.SetActive(true);
                            break;
                        case 3:
                            f_r.SetActive(true);
                            sli_r.SetActive(true);
                            break;
                        case 4:
                            f_t.SetActive(true);
                            sli_t.SetActive(true);
                            break;

                    }
                }
            }
        }
    }
	// Update is called once per frame
	void Update () {
		
	}

	public void button_on(){
	/*	
		if (ddong.activeSelf == true ) {
			ddong.SetActive (false);

			content2.fillAmount = 1;
		} /*else if (ddong2.activeSelf == true ) {

			ddong2.SetActive (false);
		}
        */

		
	}

		
}

	// Use this for initialization



