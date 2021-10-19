using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caidan : MonoBehaviour
{
    public GameObject sa;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void thisopen()
    {
        sa.SetActive(true);
    }
    public void thisclose()
    {
        sa.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
