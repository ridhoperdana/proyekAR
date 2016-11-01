using UnityEngine;
using System.Collections;

public class ClickObject : MonoBehaviour
{

    //RaycastHit hit;
    //Ray ray;
    public GameObject modelbox_1, modelbox_1a, modelbox_2, modelbox_2a, canvas, objekDiambil;
    private Canvas confirm_canvas;
    private int status = 1;
    public BoxClass kotak;
    public string jenisKotak;
    public int nilaiKotak, statusKotak;
    private GamePlay gamePlay;

    public GameObject Kotak;

    void Start()
    {
        //modelbox_1 = new GameObject();
        //modelbox_1a = new GameObject();
        //kotak = new BoxClass();
        gamePlay = GameObject.Find("GamePlay").GetComponent<GamePlay>();

        //modelbox_1 = transform.FindChild("box1").gameObject;
        modelbox_1 = GameObject.Find("target1/box1");
        modelbox_1a = GameObject.Find("target1/box1a");
        modelbox_2 = GameObject.Find("target2/box2");
        modelbox_2a = GameObject.Find("target2/box2a");
        //modelbox_1a = transform.FindChild("box2").gameObject;
        canvas = GameObject.Find("canvasPilih");

        modelbox_1.SetActive(false);
        modelbox_1a.SetActive(false);
        modelbox_2.SetActive(false);
        modelbox_2a.SetActive(false);

        int random = Random.Range(1, 3);
        int random2 = Random.Range(3, 5);

        Debug.Log("random1: " + random);
        Debug.Log("random2: " + random2);

        if (random == 1)
        {
            modelbox_1.SetActive(true);
        }
        else if (random == 2)
        {
            modelbox_1a.SetActive(true);
        }

        if (random2 == 3)
        {
            modelbox_2.SetActive(true);
        }
        else if (random2 == 4)
        {
            modelbox_2a.SetActive(true);
        }

        //modelbox_1.SetActive(false);
        canvas.SetActive(false);

        //modelbox_1a.SetActive(false);
        Debug.Log("modelbox1: ");
    }

    public void objekPilihan(GameObject obj)
    {
        obj.GetComponent<AttributKotak>().Nilai = Random.Range(0, 100);
        obj.GetComponent<AttributKotak>().NilaiRandom = Random.Range(0, 2);
        Debug.Log("nama kotak: " + obj.GetComponent<AttributKotak>().Nama);
        Kotak = obj;
    }


    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        int valueRandom;
        int valueRandomZong;
        //while(true)
        //{
        if (Input.GetMouseButtonDown(0))
        {
            if (Kotak == null)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject == modelbox_1)
                    {
                        // Write things you want to do when you click.
                        Debug.Log("objek 1 diklik");
                        objekPilihan(modelbox_1);
                        //valueRandom = Random.Range(0, 100);
                        //valueRandomZong = Random.Range(0, 2);
                        //modelbox_1a.SetActive(true);
                        modelbox_1.SetActive(false);
                        //new BoxClass("Kecil", valueRandom, valueRandomZong);
                        //jenisKotak = "Kecil";
                        //nilaiKotak = valueRandom;
                        //statusKotak = valueRandomZong;
                        canvas.SetActive(true);
                        //objekDiambil = modelbox_1;
                        //Kotak = hit.collider.gameObject;
                    }
                    else if (hit.collider.gameObject == modelbox_2)
                    {
                        Debug.Log("objek 2 diklik");
                        //valueRandom = Random.Range(0, 100);
                        //valueRandomZong = Random.Range(0, 2);
                        objekPilihan(modelbox_2);
                        modelbox_2.SetActive(false);
                        //modelbox_1.SetActive(true);
                        //new BoxClass("Besar", valueRandom, valueRandomZong);
                        //jenisKotak = "Besar";
                        //nilaiKotak = valueRandom;
                        //statusKotak = valueRandomZong;
                        canvas.SetActive(true);
                        //objekDiambil = modelbox_2;
                        //Kotak = hit.collider.gameObject;

                    }
                    else if (hit.collider.gameObject == modelbox_1a)
                    {
                        Debug.Log("objek 1a diklik");
                        //valueRandom = Random.Range(0, 100);
                        //valueRandomZong = Random.Range(0, 2);
                        objekPilihan(modelbox_1a);
                        modelbox_1a.SetActive(false);
                        //modelbox_1.SetActive(true);
                        //new BoxClass("Kecil Panjang", valueRandom, valueRandomZong);
                        //jenisKotak = "Kecil Panjang";
                        //nilaiKotak = valueRandom;
                        //statusKotak = valueRandomZong;
                        canvas.SetActive(true);
                        //objekDiambil = modelbox_1a;
                        //Kotak = hit.collider.gameObject;
                    }
                    else if (hit.collider.gameObject == modelbox_2a)
                    {
                        Debug.Log("objek 2a diklik");
                        //valueRandom = Random.Range(0, 100);
                        //valueRandomZong = Random.Range(0, 2);
                        objekPilihan(modelbox_2a);
                        modelbox_2a.SetActive(false);
                        //modelbox_1.SetActive(true);
                        //new BoxClass("Besar Panjang", valueRandom, valueRandomZong);
                        //jenisKotak = "Besar Panjang";
                        //nilaiKotak = valueRandom;
                        //statusKotak = valueRandomZong;
                        canvas.SetActive(true);
                        //objekDiambil = modelbox_2a;
                        //Kotak = hit.collider.gameObject;
                    }
                    else
                    {
                        Debug.Log("tidak klik apa2");
                    }
                }
            }
            else
            {
                Debug.Log("Sudah terpilih");
            }
        }
    }



    //}
}
