using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSalto : MonoBehaviour
{
    public Movimiento fuerzaDeSalto;


    IEnumerator temporizadorPowerUp()
    {
        yield return new WaitForSeconds(7);
        fuerzaDeSalto.fuerzaDeSalto -= 2;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SuperSalto"))
        {
            fuerzaDeSalto.fuerzaDeSalto += 2;
            StartCoroutine(temporizadorPowerUp());

            Destroy(other.gameObject);
        }
    }

}
