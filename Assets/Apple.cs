using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {
    [Header("Set in Inspector")]
    public static float bottomY = -20f;         //a

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < bottomY ){                               //a
            Destroy(this.gameObject);


            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();  //b
            apScript.AppleDestroyed();                                        //c
        }
	}
}
