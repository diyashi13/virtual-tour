using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class tovoide : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject sa;
    // Start is called before the first frame update
    void Start()
    {
        //sa = GameObject.Find("/Vist_Canvas/QueenVic/All/svoide");
    }
    public void OnPointerDown(PointerEventData eventData)
    {

    }
    public void OnPointerUp(PointerEventData eventData)
    {
   
        sa.SetActive(true);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
