using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalesAnimaciones : MonoBehaviour
{
    public  Animator leon;
    void Start()
    {
        leon = GameObject.Find("Lion").GetComponent<Animator>();
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void cambiaAnimacion(int idx)
    {
       
    }
}
