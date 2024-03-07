using System;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text timerCounter, countdownText;
    public static GameController instance;
    public int countdownTime;
    private float startTime, elapsedTime;
    private bool gamePlaying; // Declarar la variable gamePlaying

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        timerCounter.text = "Time: 00:00:00";
    }

    private void Update()
    {
        if (gamePlaying) // Actualizar el tiempo solo si el juego está en marcha
        {
            elapsedTime = Time.time - startTime;
            TimeSpan timePlaying = TimeSpan.FromSeconds(elapsedTime);
            timerCounter.text = "Time: " + timePlaying.ToString("hh':'mm':'ss");
        }
    }

    public void BeginGame()
    {
        gamePlaying = true;
        startTime = Time.time; // Corregir el operador de asignación
    }
}