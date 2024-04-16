using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSalto : MonoBehaviour
{
    public Movimiento fuerzaDeSalto;
    [SerializeField] AudioSource audio;
    [SerializeField] ParticleSystem particulas;


    IEnumerator temporizadorPowerUp()
    {
        yield return new WaitForSeconds(7);

        particulas.Stop();
        fuerzaDeSalto.fuerzaDeSalto -= 2;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SuperSalto"))
        {
            audio.Play();
            particulas.Play();

            fuerzaDeSalto.fuerzaDeSalto += 2;
            StartCoroutine(temporizadorPowerUp());

            Destroy(other.gameObject);
        }
    }

}
