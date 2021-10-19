using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mcon : MonoBehaviour
{
    public GameObject red;
    public GameObject blues;
    public GameObject sa;
    public GameObject sas;
    public GameObject saa;
    public GameObject mes;
    public bool iscans;
    // Start is called before the first frame update
    void Start()
    {
        sendm();
    }
    public void sendm()
    {
        Invoke("openthis", 5f);
    }
    public void openthis()
    {
        red.SetActive(true);
        blues.SetActive(true);
        iscans = true;
    }
    public void openthisa()
    {

            red.SetActive(false);
            blues.SetActive(false);
            sa.SetActive(false);
            sas.SetActive(true);
            saa.SetActive(true);
            mes.SetActive(false);


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
