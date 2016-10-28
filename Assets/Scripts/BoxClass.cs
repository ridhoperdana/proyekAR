using UnityEngine;
using System.Collections;

public class BoxClass : MonoBehaviour {

    /*// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}*/
    private string boxType;
    private int valueBox;

    public string getboxType()
    {
        return boxType;
    }

    public void setboxType(string type)
    {
        this.boxType = type;
    }

    public int getvaluebox()
    {
        return valueBox;
    }

    public void setvalueBox(int value)
    {
        this.valueBox = value;
    }
}
