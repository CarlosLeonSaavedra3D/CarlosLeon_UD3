using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//El objeto player es una bola con un componente transform y varias propiedades mas de Mesh.

/*Agrega una fuerza al Rigidbody.
La fuerza es aplicada continuamente a lo largo de la dirección del vector force.Especificar el ForceMode mode le permite al tipo de fuerza cambiar de una Aceleración, Impulso o Cambio de Velocidad.
La fuerza se puede aplicar a un Rigidbody activo.Si un GameObject está inactivo, AddForce no tiene efecto.
Por defecto, el estado del Rigidbody se establece a awake una vez la fuerza se aplica, al menos de que la fuerza sea Vector3.zero. */

/* La camara no puede ser hija del jugador porque si no en vez de seguirla, imita su movimiento, por lo que rotaria la camara con la pelota */


public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
