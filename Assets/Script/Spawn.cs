using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objetoRandom;
    public GameObject[] arregloDeObtaculos;
    public Vector3 spawnPoint;

    int numeroRandom;
    public float spawnTime = 4;
    public float repetition = 5;

    void Start()
    {
        InvokeRepeating("SpawnDeEnemigo", spawnTime, repetition);
    }


    void SpawnDeEnemigo()
    {
        numeroRandom = Random.Range(0, arregloDeObtaculos.Length);
        objetoRandom = arregloDeObtaculos[numeroRandom];

        Instantiate(objetoRandom, spawnPoint, objetoRandom.transform.rotation);
    }
}
