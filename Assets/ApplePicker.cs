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
            basketList.Add(tBasketGo);                  //d
        }
      }
    public void AppleDestroyed(){
        //Destroy all of the falling apples
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");      //b
        foreach (GameObject tGo in tAppleArray){
            Destroy(tGo);
        }
        //Destroy of the baskets
        //Get the index of the last Basket in basketList            //e
        int basketList = basketList.Count-1;
        //Get reference to that Basket from the LIst and destrot the GameObject
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGo);

    }
	}
	
	// Update is called once per frame
	//void Update () {
		
	//}

