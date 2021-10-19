using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkthis : MonoBehaviour
{
    public GameObject sa;
    // Start is called before the first frame update
    void Start()
    {
        sa = GameObject.Find("/UIdata");
        sa.GetComponent<UIcon>().initui();
        sa.GetComponent<UIcon>().nextstep();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
