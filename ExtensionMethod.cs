using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public static class ExtensionMethod
{
    public static void getOrAddComponent(this GameObject myGameObject ///<why> This is useful because you can easily add methods to types without having to derive and compile a new type</why>
        {

        if (myGameObject.GetComponent<ComponentA>() != null) ///<first> If component is not found</first>
        {
            myGameObject.AddComponent<ComponentA>();
        }

        else                                                ///<second> Else </second>
        {

            myGameObject.GetComponent<ComponentA>();

        }

    }



}
