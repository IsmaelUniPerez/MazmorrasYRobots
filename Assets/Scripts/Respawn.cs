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
            UnityEngine.Debug.Log("Colisi�n con el Tanque detectada. Respawneando tanque en la posici�n: " + posicionDeSpawn);

            transform.position = posicionDeSpawn;

            transform.rotation = Quaternion.identity;
        }
        else if (col.gameObject.CompareTag("Meta"))
        {
            UnityEngine.Debug.Log("�El tanque ha llegado a la meta!");
            SceneManager.LoadScene(0);
        }
    }
}
