using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMono2 : MonoBehaviour
{
    public GameObject myMono2;
    public GameObject myMono2child;
    public Component disabler;

    void onEnable()
    {
        print("onEnable");
        Instantiate(myMono2);
        GameObject myMono2child = new GameObject ();
        Instantiate(myMono2child);
        myMono2child.transform.parent = myMono2.transform;
        myMono2child.AddComponent<MyMono1>();
    }

    // Use this for initialization
    void Start()
    {
        print("start");
        myMono2.GetComponentInChildren<MyMono1>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void onDisable()
    {
        print("onDisable");
    }
}
