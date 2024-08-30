using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaPlayer : MonoBehaviour
{
    public int maxVida = 10;
    private int vidaActual;
    void Start()
    {
        vidaActual = maxVida;
    }
    public void Damage(int cantidad)
    {
        vidaActual = vidaActual - cantidad;

        if (vidaActual <= 0)
        {
            vidaActual = 0;
            SceneManager.LoadScene("Resultado");
        }
    }
}
