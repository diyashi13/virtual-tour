using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class toxini : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    
    public GameObject sa;
    public int stepi;
    // Start is called before the first frame update
    void Start()
    {
        sa = GameObject.Find("/UIdata");
    }
    //public void OnPointerClick(PointerEventData eventData)
    //{
    //    print("sasa");
    //    sa.GetComponent<UIcon>().UIsize = 4;
    //    Application.LoadLevel("xini");
    //}
    public void OnPointerDown(PointerEventData eventData)
    {
        
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        print("sasa");
        sa.GetComponent<UIcon>().UIsize = stepi;
        Application.LoadLevel("xini");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
