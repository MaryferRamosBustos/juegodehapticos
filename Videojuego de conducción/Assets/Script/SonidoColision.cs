using UnityEngine;

public class SonidoColision : MonoBehaviour
{
    public AudioClip sonidoColision;

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si la colisión involucra al objeto con el que se adjunta el script
        if (collision.gameObject.CompareTag("ObjetoColisionable"))
        {
            // Reproduce el sonido de colisión
            AudioSource.PlayClipAtPoint(sonidoColision, transform.position);
        }
    }
}