using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField] float rapidez;
    [SerializeField] float tiempoMax;
    [SerializeField] float tiempoActual;


    void Update()
    {
        transform.position -= new Vector3(0, 0, rapidez * Time.deltaTime);

        tiempoActual += Time.deltaTime;

        if (tiempoMax <= tiempoActual)
            Destroy(this.gameObject);
    }
}
