using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorDeEscenas : MonoBehaviour
{
    public void CargarEscenaJuego()
    {
        SceneManager.LoadScene(1);
    }
    public void CargarEscenaMenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    public void CargarEscenaOpciones()
    {
        SceneManager.LoadScene(2);
    }
    public void SalirJuego()
    {
        UnityEngine.Debug.Log("Saliendo del juego");
        UnityEngine.Application.Quit();
    }
}
