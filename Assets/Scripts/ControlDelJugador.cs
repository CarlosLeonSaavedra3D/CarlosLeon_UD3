using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControlDelJugador : MonoBehaviour
{
    //Almacena componente RigiBody del personaje jugador
    Rigidbody rb;
    public float velocidad;

    public void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        rb.AddForce(movimiento * velocidad);
    }

    public float contador;
    public Text marcador;
    public Text findejuego;


    void ActualizarMarcador()
    {
        marcador.text = "Puntos: " + contador;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        marcador.text = "Puntos: " + contador;
        findejuego.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        contador = contador + 1;
        ActualizarMarcador();
        if(contador >= 4)
        {
            findejuego.gameObject.SetActive(true);
        }
    }
}
