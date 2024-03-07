using UnityEngine;

public class CarroVidas : MonoBehaviour
{
    public int vidas = 3;
    public GameObject menuFin; // Referencia al GameObject que contiene el script de Fin

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo")) // Verifica si colisionó con un enemigo
        {
            vidas--; // Reduce las vidas
            Debug.Log("Vidas restantes: " + vidas);

            if (vidas <= 0)
            {
                // Si el carro pierde todas las vidas, activa el menú de Fin
                menuFin.SetActive(true);
            }
        }
    }
}