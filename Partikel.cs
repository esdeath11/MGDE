using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Partikel : MonoBehaviour
{

    
    public bool isGround;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(isGround == true)
        {
            
            Destroy(this.gameObject);
        }
    }

    




}
