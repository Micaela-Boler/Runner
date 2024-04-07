using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Manager : MonoBehaviour
{
    public Puntaje puntosScript;
    [SerializeField] TextMeshProUGUI puntajeFinal;



    void Start()
    {
        gameObject.SetActive(false);
    }



    public void ActivarPantalla()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;

        puntajeFinal.text = "Puntaje final: " + (puntosScript.puntos * 10).ToString("0");
    }

    public void Reset()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }


}
