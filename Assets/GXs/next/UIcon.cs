using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcon : MonoBehaviour
{
    public int UIsize;
    public GameObject welcomes;
    public GameObject Vist_Canvas;
    public GameObject FirstPage;
    public GameObject SecondPage;
    public GameObject ThreePage;
    public GameObject Homep;
    public GameObject Mapp;
    public GameObject pAustralia;
    public GameObject PSydney;
    public GameObject GB02;
    //public GameObject ProfilePage;
    public GameObject MapPage;
    //public GameObject PMain;
    public static bool isHave = false;
    private GameObject clone;//克隆的不销毁物体
    // Start is called before the first frame update
    void Start()
    {
  
        if (!isHave)
        {
            clone = this.gameObject;
            isHave = true;
            DontDestroyOnLoad(clone);
        }
    }
    public void initui()
    {
        welcomes = GameObject.Find("/welcome");
        Vist_Canvas = GameObject.Find("/Vist_Canvas");
        FirstPage = GameObject.Find("/Vist_Canvas/FirstPage");
        SecondPage = GameObject.Find("/Vist_Canvas/SecondPage");
        ThreePage = GameObject.Find("/Vist_Canvas/ThreePage");
        MapPage = GameObject.Find("Vist_Canvas/MapPage");
        Homep = GameObject.Find("Vist_Canvas/Home");
        Mapp = GameObject.Find("Vist_Canvas/Map");
        pAustralia = GameObject.Find("Vist_Canvas/MapPage/Australia");
        PSydney = GameObject.Find("Vist_Canvas/MapPage/Sydney");
        GB02 = GameObject.Find("Vist_Canvas/MapPage/Sydney/GB (2)");
        //ProfilePage = GameObject.Find("Vist_Canvas/ProfilePage");
        //PMain = GameObject.Find("Vist_Canvas/ProfilePage/Main");
        SecondPage.SetActive(false);
        ThreePage.SetActive(false);
        Vist_Canvas.SetActive(false);
        Homep.SetActive(false);
        Mapp.SetActive(false);
        MapPage.SetActive(false);
        PSydney.SetActive(false);
        GB02.SetActive(false);
        pAustralia.SetActive(true);
        //ProfilePage.SetActive(false);
    }
    public void nextstep()
    {
        switch (UIsize)
        {
            case 1:
                welcomes.SetActive(false);
                Vist_Canvas.SetActive(true);
                FirstPage.SetActive(true);
                SecondPage.SetActive(false);
                ThreePage.SetActive(false);
                Homep.SetActive(false);
                Mapp.SetActive(true);
                PSydney.SetActive(true);
                GB02.SetActive(true);
                MapPage.SetActive(true);
                break;
            case 3:
                welcomes.SetActive(false);
                Vist_Canvas.SetActive(true);
                FirstPage.SetActive(true);
                SecondPage.SetActive(true);
                ThreePage.SetActive(false);
                Homep.SetActive(true);
                break;
            case 4:
                welcomes.SetActive(false);
                Vist_Canvas.SetActive(true);
                FirstPage.SetActive(true);
                SecondPage.SetActive(true);
                ThreePage.SetActive(true);
                Homep.SetActive(true);
                break;
            
        }
    }
    // Update is called once per frame
    void Update()
    {
   
    }
}
