using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeLaCamara : MonoBehaviour
{
    public GameObject Jugador;
    private Vector3 posicionRelativa;

    // Use this for initialization
    private void Start()
    {
        posicionRelativa = transform.position - Jugador.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = Jugador.transform.position + posicionRelativa;
    }
}
