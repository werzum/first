using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NewBehaviourScript : MonoBehaviour {

    public string response;
    NewBehaviourScript test = new NewBehaviourScript();

	// Use this for initialization
	void Start () {
        UnityWebRequest response1 = UnityWebRequest.Get("http://httpbin.org/get");
        response = response1.ToString();
        test = JsonUtility.FromJson<NewBehaviourScript>(response);
        print(test.GetProperties());
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
