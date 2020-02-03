using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerJump : MonoBehaviour
{
    public GameObject Player;

    private void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "tanah")
        {
            Player.GetComponent<PlayerMovement>().isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "tanah")
        {
            Player.GetComponent<PlayerMovement>().isGround = false;
        }
    }
}
