using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMono1 : MonoBehaviour {

    void onEnable ()
    {
        print("onEnable");
    }

	// Use this for initialization
	void Start () {
        print("start");
	}
	
	// Update is called once per frame
	void Update () {

	}

    void onDisable () {
        print("onDisable");
    }
}
