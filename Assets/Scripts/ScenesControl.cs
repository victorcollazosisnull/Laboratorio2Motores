using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesControl : MonoBehaviour
{
    public string Escena;
    public string menu;
    public string SampleScene;
    public void CambioEscena()
    {
        SceneManager.LoadScene(Escena);
    }
    public void volverAlMenu()
    {
        SceneManager.LoadScene(menu);
    }
    public void Reintentar()
    {
        SceneManager.LoadScene(SampleScene);
    }
}
