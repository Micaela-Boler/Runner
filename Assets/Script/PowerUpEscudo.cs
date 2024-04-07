using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpEscudo : MonoBehaviour
{
    public bool activarEscudo;

    IEnumerator temporizadorPowerUp()
    {
        yield return new WaitForSeconds(5);
        activarEscudo = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Escudo"))
        {
            activarEscudo = true;
            StartCoroutine(temporizadorPowerUp());

            Destroy(other.gameObject);
        }
    }
}
