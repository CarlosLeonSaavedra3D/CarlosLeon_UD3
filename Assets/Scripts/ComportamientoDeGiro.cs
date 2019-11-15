using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoDeGiro : MonoBehaviour
{
    Vector3 velociadadRotacion = new Vector3(15, 30, 45);

    //Update is called once per frame
    private void Update()
    {
        transform.Rotate(velociadadRotacion * 3 * Time.deltaTime);
    }
}