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


    [Header("Movimiento vertical y horizontal")]

    private float horizontal;
    private Vector3 movimiento;
    [SerializeField] int speed;

    Animator animator;
    public Manager manager;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }



    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        movimiento = new Vector3(horizontal, 0f, 0);

        movimiento.Normalize();

        transform.Translate(movimiento * speed * Time.deltaTime);


        //Salto

        if (saltando && Input.GetButtonDown("Jump"))
        {
            _rb.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
            saltando = false;

            animator.SetBool("animacionSaltar", true);
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            saltando = true;
            animator.SetBool("animacionSaltar", false);
        }


        if (collision.gameObject.CompareTag("Enemigo"))
            manager.ActivarPantalla();
    }
}
