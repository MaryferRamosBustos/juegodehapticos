using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoria : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    // Función para intentar de nuevo
    public void JugarDeNuevo()
    {
        Application.LoadLevel("scena 2");
    }

    // Función para salir
    public void Salir()
    {
        // Aquí puedes agregar cualquier lógica que desees al salir del juego
        Application.Quit();
    }
}