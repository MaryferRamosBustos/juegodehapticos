using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fin : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    // Función para intentar de nuevo
    public void IntentarDenuevo()
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