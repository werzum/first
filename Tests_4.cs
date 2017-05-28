using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class NewEditorTest {

    public string jsonstring;
    public string jsonstring2;
    NewEditorTest test = new NewEditorTest;

	public NewEditorTest jsonToC(string jsonstring)
    {
        NewEditorTest test = JsonUtility.FromJson<NewEditorTest>(jsonstring);
    }

    public string cToJson(NewEditorTest)
    {
        jsonstring = JsonUtility.ToJson(this);
    }

    public void checkIfEqual()
    {
        Assert.AreEqual(jsonstring, jsonstring2);

    }

	
}
