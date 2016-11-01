using UnityEngine;
using System.Collections;

public class BoxClass : MonoBehaviour {
    private string boxType;
    private int valueBox, status;
    /*// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}*/
    public BoxClass(string type, int value, int status)
    {
        this.boxType = type;
        this.valueBox = value;
        this.status = status;
    }
    

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

    public int getstatusBox()
    {
        return status;
    }

    public void setstatusBox(int value)
    {
        this.status = value;
    }
}
