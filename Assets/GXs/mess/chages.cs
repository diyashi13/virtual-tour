using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chages : MonoBehaviour
{
    public RectTransform saa;
    public RectTransform saa01;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void sa()
    {
        this.GetComponent<ScrollRect>().content = saa;
    }
    public void saaq()
    {
        this.GetComponent<ScrollRect>().content = saa01;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
