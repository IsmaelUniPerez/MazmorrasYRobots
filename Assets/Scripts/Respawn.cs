using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public Vector3 posicionDeSpawn = new Vector3(0f, 0.6f, 0f);

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("ZonaMuerte"))
        {
            UnityEngine.Debug.Log("Colisión con el Tanque detectada. Respawneando tanque en la posición: " + posicionDeSpawn);

            transform.position = posicionDeSpawn;

            transform.rotation = Quaternion.identity;
        }
        else if (col.gameObject.CompareTag("Segundo Nivel"))
        {
            UnityEngine.Debug.Log("¡El tanque ha llegado al segundo nivel!");
            SceneManager.LoadScene(2);
        }
        else if (col.gameObject.CompareTag("Meta"))
        {
            UnityEngine.Debug.Log("¡El tanque ha llegado a la meta del nivel 2!");
            SceneManager.LoadScene(3);
        }
        else if (col.gameObject.CompareTag("Finish"))
        {
            UnityEngine.Debug.Log("¡El tanque ha llegado a la meta del nivel de agua!");
            SceneManager.LoadScene(0);
        }
    }
}
