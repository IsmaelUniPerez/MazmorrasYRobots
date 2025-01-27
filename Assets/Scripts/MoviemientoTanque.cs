using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviemientoTanque : MonoBehaviour
{
    public float velocidadMovimiento = 5f; // Speed at which the tank moves
    public float velocidadRotacion = 100f; // Speed at which the tank rotates

    void Start()
    {
        // You can initialize values or setup things at the start of the game if needed
    }

    void Update()
    {
        // Movimiento hacia adelante con la tecla W
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * velocidadMovimiento * Time.deltaTime);
        }

        // Movimiento hacia atrás con la tecla S
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * velocidadMovimiento * Time.deltaTime);
        }

        // Rotación hacia la izquierda con la tecla A
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -velocidadRotacion * Time.deltaTime);
        }

        // Rotación hacia la derecha con la tecla D
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, velocidadRotacion * Time.deltaTime);
        }
        // Move the tank forward or backward based on vertical input (W/S or Arrow Keys)
        float movimiento = Input.GetAxis("Vertical") * velocidadMovimiento * Time.deltaTime;

        // Rotate the tank based on horizontal input (A/D or Arrow Keys)
        float rotacion = Input.GetAxis("Horizontal") * velocidadRotacion * Time.deltaTime;

        // Apply movement
        transform.Translate(0, 0, movimiento); // Moves the tank along its local Z axis

        // Apply rotation
        transform.Rotate(0, rotacion, 0);
    }
    }
