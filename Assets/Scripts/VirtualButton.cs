using UnityEngine;
using System.Collections;
using Vuforia;
using System;

public class VirtualButton : MonoBehaviour , IVirtualButtonEventHandler
{

    private GameObject model_box1, model_box1a, btnpilih;
    private int status = 1;

    // Use this for initialization
    void Start () {

        //model_box1 = new GameObject();
        //model_box1a = new GameObject();
        //btnpilih = new GameObject();

        model_box1 = transform.FindChild("box1").gameObject;
        model_box1a = transform.FindChild("box1a").gameObject;
        btnpilih = transform.FindChild("pilih").gameObject;
        model_box1a.SetActive(false);

        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            // Register with the virtual buttons TrackableBehaviour
            vbs[i].RegisterEventHandler(this);
        }
    }
	
	// Update is called once per frame
	//void Update () {
      //  OnButtonPressed();
	//}

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        if(vb.VirtualButtonName == "tombol1")
        {
            if(status==1)
            {
                model_box1.SetActive(false);
                model_box1a.SetActive(true);
                status = 2;
                Debug.Log("status sekarang: " + status);
            }
            else if(status==2)
            {
                model_box1.SetActive(true);
                model_box1a.SetActive(false);
                status = 1;
                Debug.Log("status sekarang: " + status);
            }
            //throw new UnityException("Button not supported: " + vb.VirtualButtonName);
        }
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        throw new NotImplementedException();
    }
}
