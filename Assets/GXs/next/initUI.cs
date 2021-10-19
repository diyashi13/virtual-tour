using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initUI : MonoBehaviour
{
    public GameObject mainpage;
    public GameObject messgers;
    public GameObject messger2;
    public GameObject Moments;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void initUIms()
    {
        mainpage.SetActive(true);
        messgers.SetActive(false);
        messger2.SetActive(false);
        Moments.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
