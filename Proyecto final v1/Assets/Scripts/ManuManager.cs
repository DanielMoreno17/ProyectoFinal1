using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManuManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject panelLeon;
    [SerializeField] GameObject panelPinguino;
    [SerializeField] GameObject panelChicken;
    [SerializeField] GameObject titulo;

    void Start()
    {
        // Update is called once per frame
    }  
    
    public void estadoPanel(bool val)
    {
       panelLeon.SetActive(val);
    }
    public void estadoChicken(bool val)
    {
        panelChicken.SetActive(val);
    }

    public void estadoTitulo(bool val)
    {
        titulo.SetActive(val);
    }

    public void panelPingui(bool val)
    {
        panelPinguino.SetActive(val);
    }

}
