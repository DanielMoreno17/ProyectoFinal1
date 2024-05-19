using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimations : MonoBehaviour
{
    public Animator anim,modelo2,modelo3;
    void Start()
    {
        anim = GameObject.Find("Personaje").GetComponent<Animator>();
        modelo2 = GameObject.Find("Modelo2").GetComponent<Animator>();
        modelo3 = GameObject.Find("Modelo3").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambiaAnimacion (int idx)
    {
        if(idx == 1) 
        {
            anim.Play("Capoeria");
            modelo2.Play("Capoeira");
            modelo3.Play("Capoeira");
        }else if(idx == 2)
        {
            anim.Play("Claps");
            modelo2.Play("Claps");
            modelo3.Play("Claps");
        }
        else if(idx == 3)
        {
            anim.Play("Morido");
            modelo2.Play("Morir");
            modelo3.Play("Morir");
        }
    }
}
