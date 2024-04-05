using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI texto;
    public float puntos;


    void Update()
    {
        puntos += Time.deltaTime;
        texto.text = (puntos * 10).ToString("0");
    }
}
