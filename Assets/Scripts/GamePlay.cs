using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class GamePlay : MonoBehaviour{

    public BoxClass boxObject;
    public Text shownType;
    public ClickObject canvasPass;
    public Button tombolIya;
    public GameObject canvas;
    private GameObject canvasBox;
    public ClickObject kotak;
    string tmpJenis;
    

	// Use this for initialization
	void Start () {
        boxObject = new BoxClass();
        shownType.text = "belum ada";
        kotak = GetComponent<ClickObject>();
        //shownType = canvasBox.GetComponent<Text>();
        //canvas = GameObject.Find("canvasPilih");
        //tombolIya = GameObject.Find("canvasPilih/btnPilih").GetComponent<Button>();
        Debug.Log("jenis: " + tmpJenis);
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    public void tombolDitekan()
    {
        tmpJenis = kotak.jenisKotak;
        //if (!EventSystem.current.IsPointerOverGameObject())
        //{
            Debug.Log("masuk != eventsystem");
            tombolIya.onClick.AddListener(() => assignBox(tmpJenis));
        //}
    }

    public void assignBox(string type)
    {
        boxObject.setboxType(type);
        boxObject.setvalueBox(10);
        shownType.text = type;
        //canvas.SetActive(false);
        canvas.SetActive(false);
        Debug.Log("tipe: " + type);
        Debug.Log("nilai: " + boxObject.getvaluebox());
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
