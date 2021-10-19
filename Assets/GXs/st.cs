using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class st : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void closethis()
    {
       this.gameObject.SetActive(false);
    }
    public void openthis()
    {
        this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
