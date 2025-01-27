using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

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
    }
}
