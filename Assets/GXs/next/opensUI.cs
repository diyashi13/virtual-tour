using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opensUI : MonoBehaviour
{
    public GameObject sa;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void openthisa()
    {

        sa.SetActive(true);

    }
    public void closethissa()
    {
        sa.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
