using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mgo : MonoBehaviour
{
    public bool iscans;
    public GameObject sa;
    public GameObject sa01;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void iszx()
    {
        iscans = true;
    }
    public void sad()
    {
        if (iscans)
        {
            sa.SetActive(true);
            sa01.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
