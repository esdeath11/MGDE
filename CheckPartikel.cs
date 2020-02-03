using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPartikel : MonoBehaviour
{
    public GameObject partikel;
    void Start()
    {
        partikel = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "tanah" || collision.collider.tag == "Player")
        {
            partikel.GetComponent<Partikel>().isGround = true;
        }
    }
}
