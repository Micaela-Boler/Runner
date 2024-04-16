using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpEscudo : MonoBehaviour
{
    public bool activarEscudo;
    [SerializeField] AudioSource audio;
    [SerializeField] ParticleSystem particulas;


    IEnumerator temporizadorPowerUp()
    {
        yield return new WaitForSeconds(5);

        particulas.Stop();
        activarEscudo = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Escudo"))
        {
            audio.Play();
            particulas.Play();

            activarEscudo = true;
            StartCoroutine(temporizadorPowerUp());

            Destroy(other.gameObject);
        }
    }
}
