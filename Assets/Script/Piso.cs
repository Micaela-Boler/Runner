using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Piso : MonoBehaviour
{
    public float offsetX = 99.8f;
    public float floorPosition = 26.2404f;
    public float floorSpeed = 7;


    void Update()
    {
        transform.position -= new Vector3(0, 0, floorSpeed * Time.deltaTime);

        if (transform.position.z <= -offsetX)
            transform.position = new Vector3(transform.position.x, transform.position.y, floorPosition);

    }
}
