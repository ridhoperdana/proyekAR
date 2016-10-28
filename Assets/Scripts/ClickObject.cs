using UnityEngine;
using System.Collections;

public class ClickObject : MonoBehaviour {

    //RaycastHit hit;
    //Ray ray;
    public GameObject modelbox_1, modelbox_1a, canvas;
    private Canvas confirm_canvas;
    private int status = 1;
    public BoxClass kotak;
    public string jenisKotak;
    public int nilaiKotak;
    private GamePlay gamePlay;
    
    void Start () {
        modelbox_1 = new GameObject();
        modelbox_1a = new GameObject();
        kotak = new BoxClass();
        gamePlay = GameObject.Find("GamePlay").GetComponent<GamePlay>();

        //modelbox_1 = transform.FindChild("box1").gameObject;
        modelbox_1 = GameObject.Find("target1/box1");
        modelbox_1a = GameObject.Find("target2/box2");
        //modelbox_1a = transform.FindChild("box2").gameObject;
        canvas = GameObject.Find("canvasPilih");

        //modelbox_1.SetActive(false);
        canvas.SetActive(false);

        //modelbox_1a.SetActive(false);
        Debug.Log("modelbox1: ");
    }
    
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        //while(true)
        //{
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(ray, out hit))
                {
                    //Debug.Log(" you clicked on " + hit.collider.gameObject.name);

                    if (hit.collider.tag == "box1" || hit.collider.gameObject.name == "box1")
                    {
                        // Write things you want to do when you click.
                        Debug.Log("objek 1 diklik");
                        //modelbox_1a.SetActive(true);
                        modelbox_1.SetActive(false);
                        kotak.setboxType("Kecil");
                        kotak.setvalueBox(20);
                        jenisKotak = "Kecil";
                        nilaiKotak = 20;
                        canvas.SetActive(true);
                    }
                    else if (hit.collider.tag == "box2" || hit.collider.gameObject.name == "box2")
                    {
                        Debug.Log("objek 2 diklik");
                        modelbox_1a.SetActive(false);
                        //modelbox_1.SetActive(true);
                        kotak.setboxType("Besar");
                        kotak.setvalueBox(100);
                        jenisKotak = "Besar";
                        nilaiKotak = 100;
                        canvas.SetActive(true);
                    }
                    else
                    {
                        Debug.Log("tidak klik apa2");
                    }
                }
            }
        }
        
        
    //}
}
