using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [Header("Salto")]

    public float fuerzaDeSalto;
    private Rigidbody _rb;
    bool saltando;

    Animator animator;
    AudioSource audio;


    [Header("Movimiento horizontal")]

    private float horizontal;
    private Vector3 movimiento;
    [SerializeField] int speed;


    [Header("Power up escudo")]

    public Manager manager;
    public PowerUpEscudo escudo;



    void Start()
    {
        _rb = GetComponent<Rigidbody>();

        animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }



    void Update()
    {
        // Movimiento horizontal

        horizontal = Input.GetAxis("Horizontal");
        movimiento = new Vector3(horizontal, 0f, 0);

        transform.Translate(movimiento * speed * Time.deltaTime);


        // Salto

        if (saltando && Input.GetButtonDown("Jump"))
        {
            _rb.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
            saltando = false;

            animator.SetBool("animacionSaltar", true);
            audio.Play();
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            saltando = true;
            animator.SetBool("animacionSaltar", false);
        }
    }


    // Activar pantalla de Game Over

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Enemigo"))
        {
            if (escudo.activarEscudo == false)
                manager.ActivarPantalla();
            else Destroy(other.gameObject);
        }
    }
}
