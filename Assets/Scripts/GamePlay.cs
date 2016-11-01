using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class GamePlay : MonoBehaviour{

    public BoxClass boxObject;
    public Text shownType;
    public ClickObject canvasPass;
    public Button tombolIya, tombolMenu;
    public GameObject canvas;
    private GameObject canvasBox;
    public ClickObject kotak;
    string tmpJenis;
    int tmpValue, tmpStatus;
    public GameObject kotakDapat;
    public GameObject canvasBaru;
    public int status_menu_inventory = 0;

    public GameObject GambarDipilih;

    // Use this for initialization
    void Start () {
        //boxObject = new BoxClass();
        shownType.text = "belum ada";
        kotak = GetComponent<ClickObject>();
        canvasBaru.SetActive(false);
        //Debug.Log("jenis: " + tmpJenis);
        //canvasBaru = GameObject.Find("canvasInventory");
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    public void tombolDitekan()
    {
        //tmpJenis = kotak.jenisKotak;
        //tmpValue = kotak.nilaiKotak;
        //tmpStatus = kotak.statusKotak;
        tmpJenis = GetComponent<ClickObject>().Kotak.GetComponent<AttributKotak>().Nama;
        tmpValue = GetComponent<ClickObject>().Kotak.GetComponent<AttributKotak>().Nilai;
        tmpStatus = GetComponent<ClickObject>().Kotak.GetComponent<AttributKotak>().NilaiRandom;
        if (GetComponent<ClickObject>().Kotak)
        {
            GambarDipilih.GetComponent<Image>().sprite = GetComponent<ClickObject>().Kotak.GetComponent<AttributKotak>().Gambar;
        }
        tombolIya.onClick.AddListener(() => assignBox(tmpJenis, tmpValue, tmpStatus));
    }

    public void tombolMenuDitekan()
    {
        Debug.Log("status_menu_ditekan: " + status_menu_inventory);
        if (status_menu_inventory == 0)
        {
            Debug.Log("masuk 0");
            //kotakDapat = kotak.objekDiambil;
            if (GetComponent<ClickObject>().Kotak != null)
            {
                //canvasBaru.SetActive(true);
                tombolMenu.onClick.AddListener(() => lihatInventory(GetComponent<ClickObject>().Kotak));
            }
            else
            {
                canvasBaru.SetActive(true);
                status_menu_inventory = 1;
            }
            //tombolMenu.onClick.AddListener(() => lihatInventory(kotakDapat));
        }
        else if (status_menu_inventory == 1)
        {
            Debug.Log("masuk 1");
            canvasBaru.SetActive(false);
            status_menu_inventory = 0;
            Debug.Log("status_menu_ditekan dalam 1: " + status_menu_inventory);
        }
        else
            Debug.Log("tidak masuk");

    }

    public void lihatInventory(GameObject obj)
    {
        canvasBaru.SetActive(true);
        obj.SetActive(true);
        status_menu_inventory = 1;
    }

    public void assignBox(string type, int value, int status)
    {
        //boxObject.setboxType(type);
        //boxObject.setvalueBox(10);
        //boxObject = new BoxClass(type, value, status);
        //shownType.text = boxObject.getboxType();
        shownType.text = GetComponent<ClickObject>().Kotak.GetComponent<AttributKotak>().Nama;
        //canvas.SetActive(false);
        canvas.SetActive(false);
        Debug.Log("tipe: " + GetComponent<ClickObject>().Kotak.GetComponent<AttributKotak>().Tipe);
        Debug.Log("nilai: " + GetComponent<ClickObject>().Kotak.GetComponent<AttributKotak>().Nilai);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void TombolTutupMenuInventory()
    {
        canvasBaru.SetActive(false);
        GetComponent<ClickObject>().Kotak = null;
    }
}
