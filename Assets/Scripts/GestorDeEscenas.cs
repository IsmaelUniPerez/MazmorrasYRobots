using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorDeEscenas : MonoBehaviour
{
    public void CargarEscena()
    {
        SceneManager.LoadScene(1);
    }
}
