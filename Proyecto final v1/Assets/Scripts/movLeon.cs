using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movLeon : MonoBehaviour
{
    [SerializeField]
    Transform barrera;

    [SerializeField]
    List<Transform> puntos;

    [SerializeField]
    int indice_destino;

    [SerializeField]
    float velocidad;

    GameObject plano;
    Vector3 rotacionFuente;

    // Start is called before the first frame update
    void Start()
    {
        plano = GameObject.Find("plano");
        rotacionFuente = plano.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        barrera.position = Vector3.MoveTowards(barrera.position,
            puntos[indice_destino].position, velocidad * Time.deltaTime
            );

        if (Vector3.Distance(barrera.position,
            puntos[indice_destino].position) <= 0.1)
        {

            indice_destino = ++indice_destino % puntos.Count;
            barrera.LookAt(puntos[indice_destino].position);

        }

    }

}