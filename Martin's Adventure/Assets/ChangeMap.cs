using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMap : MonoBehaviour
{
    public GameObject map1;
    public GameObject map2;
    public bool mapChill = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && mapChill)
        {
            mapChill = false;
            map2.SetActive(false);
            map1.SetActive(true);
            
                
        }else if(Input.GetKeyDown("space") && mapChill == false)
        {
            mapChill = true;
            map2.SetActive(true);
            map1.SetActive(false);
            
        }
    }
}
