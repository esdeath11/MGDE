using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public bool isGround;
    public int Count = 0;
    public AudioSource audio;
    public AudioClip hitsound;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        kondisi();
        if(isGround == true)
        {
            Score.scoreValue += 1;
            Timer.currenTime += 1;
         //   Debug.Log("hai");
        }
    }

    void kondisi()
    {
        if(Timer.currenTime < 1)
        {
            Destroy(this.gameObject);
            isGround = false;
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "partikel")
        {
            audio.PlayOneShot(hitsound);
        }
    }

}
