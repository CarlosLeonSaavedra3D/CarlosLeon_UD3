using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControlDelJugador : MonoBehaviour
{
    //Almacena componente RigiBody del personaje jugador
    Rigidbody rb;
    public float velocidad;
    int numItem1;
    int numItem2;

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

        if (other.tag == "suma1")
        {
            Destroy(other.gameObject);
            contador = contador + 1;
            numItem1 = numItem1 + 1;
        }
        else if (other.tag == "suma2")
        {
            Destroy(other.gameObject);
            contador = contador + 2;
            numItem2 = numItem2 + 1;
        }
        ActualizarMarcador();
        if (contador >= 9)
        {
            findejuego.gameObject.SetActive(true);
        }

    }
}
