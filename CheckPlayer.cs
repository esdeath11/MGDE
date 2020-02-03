using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayer : MonoBehaviour
{
    public GameObject player;
    


    void Start()
    {
        player = gameObject.transform.parent.gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "partikel")
        {
            
            player.GetComponent<Player>().isGround = true;
            

            //   Debug.Log("test");  
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "partikel")
        {
            player.GetComponent<Player>().isGround = false;
          //  Debug.Log("test false");
        }
    }

}
