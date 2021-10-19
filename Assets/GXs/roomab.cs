using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomab : MonoBehaviour
{
    //Rigidbody rigidbody;
    public string mPath1;
    public string p;
    public string p2;
    public float speed;
    public float xuanspeed;
    public bool iscans;
    public bool isforwas;
    public bool isbacks;
    public bool islefts;
    public bool isrights;
    public int zs;
    public GameObject sa;
    public GameObject sa1;
    public AudioClip ka;
    void Start()
    {
        p = "/ScreenShot/";
        //rigidbody = GetComponent<Rigidbody>();
    }

    public void CaptureScreen()
    {
        sa.SetActive(false);
        Invoke("opensa", 0.1f);
        print("kkk");
        zs++;
        p2 = zs.ToString()+".png";
        mPath1 = Application.dataPath + p + p2;
        CaptureByUnity(mPath1);

    }
    public void opensa()
    {
        sa.SetActive(true);
    }
    public void CaptureByUnity(string mFileName)
    {
        ScreenCapture.CaptureScreenshot(mFileName,0);
        sa1.GetComponent<st>().openthis();
        playthis();
        Invoke("chosest", 1f);

    }
    public void chosest()
    {
        sa1.GetComponent<st>().closethis();
    }
    public void playthis()
    {
        this.GetComponent<AudioSource>().Play();
    }
    // Update is called once per frame
    public void forwa()
    {
        if (iscans&&isforwas)
        {
            transform.Translate(Vector3.forward * speed*0.01f);
        }
 
    }
    public void backs()
    {
        if (iscans && isbacks)
        {
            transform.Translate(Vector3.forward * speed * -0.01f);
        }

    }
    public void lefts()
    {
        if (iscans && islefts)
        {
            this.transform.localEulerAngles = new Vector3(this.transform.localEulerAngles.x, this.transform.localEulerAngles.y - xuanspeed, this.transform.localEulerAngles.z);
        }

    }
    public void rights()
    {
        if (iscans && isrights)
        {
            this.transform.localEulerAngles = new Vector3(this.transform.localEulerAngles.x, this.transform.localEulerAngles.y + xuanspeed, this.transform.localEulerAngles.z);
        }

    }
    public void iscanforwa()
    {
        iscans = true;
        isforwas = true;
        isbacks = false;
    }
    public void isnotcanforwa()
    {
        iscans = false;
        isforwas = false;
    }
    public void iscanbacks()
    {
        iscans = true;
        isforwas = false;
        isbacks = true;
    }
    public void isnotcanbacks()
    {
        iscans = false;
        isbacks = false;
    }
    public void iscanzuos()
    {
        iscans = true;
        islefts = true;
        isrights = false;
    }
    public void isnotcanzuos()
    {
        iscans = false;
        islefts = false;
    }
    public void iscanyous()
    {
        iscans = true;
        islefts = false;
        isrights = true;
    }
    public void isnotcanyous()
    {
        iscans = false;
        isrights = false;
    }
    void FixedUpdate()
    {
        forwa();
        backs();
        lefts();
        rights();
        //    if (Input.GetKeyDown(KeyCode.W))
        //    {
        //        iscans = true;
        //    }
        //    if (Input.GetKeyUp(KeyCode.W))
        //    {
        //        iscans = false;
        //    }
        //    if (Input.GetKeyDown(KeyCode.K))
        //{
        //    CaptureScreen();
        //}
    }
 


        //float v = Input.GetAxis("Vertical");
        //rigidbody.velocity = transform.forward * v * speed;
        //float h = Input.GetAxis("Horizontal");
        //rigidbody.angularVelocity = transform.up * h * xuanspeed;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="laji")
        {
            Destroy(other.gameObject);
        }
    }
}

