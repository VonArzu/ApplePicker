using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour {
    [Header("Set in Inspector")]                    //a
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;

	// Use this for initialization
	void Start () {
        basketList = new List<GameObject>();                //c
        for (int i = 0; i < numBaskets; i++){
            GameObject tBasketGo = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGo.transform.position = pos;
            object basketList = basketList;
            basketList.Add(tBasketGo);                  //d
        }
      }
    public void AppleDestroyed(){
        //Destroy all of the falling apples
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");      //b
        foreach (GameObject tGo in tAppleArray){
            Destroy(tGo);
        }

     if(basketList.Count == 0)
        {
            SceneManager.LoadScene("_Scene_0");
        }

    }
	}
	
	// Update is called once per frame
	//void Update () {
		
	//}

