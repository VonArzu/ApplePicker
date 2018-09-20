using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI //Remember. we need this line for uGUI to work.

public class HighScrore : MonoBehaviour {
    static public int score = 1000;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " +score;
		
	}
}
