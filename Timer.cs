using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    

    public static float currenTime = 0;
    float StartTime = 10;
   [SerializeField] Text timer;


    void Start()
    {
        currenTime = StartTime;    
    }

    // Update is called once per frame
    void Update()
    {
        currenTime -= 1 * Time.deltaTime;
        timer.text = currenTime.ToString("0");
    }
}
