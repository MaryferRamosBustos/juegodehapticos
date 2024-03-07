using UnityEngine;

public class ControlVolante : MonoBehaviour
{
    public float velocidadGiro = 1f; // Velocidad de giro del volante
    public float maxAngulo = 45f; // Máximo ángulo de giro del volante

    private bool girandoIzquierda = false;
    private bool girandoDerecha = false;
    private float anguloActual = 0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            girandoIzquierda = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            girandoIzquierda = false;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            girandoDerecha = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            girandoDerecha = false;
        }

        if (girandoIzquierda)
        {
            anguloActual = Mathf.MoveTowards(anguloActual, -maxAngulo, velocidadGiro * Time.deltaTime);
            transform.localRotation = Quaternion.Euler(0f, anguloActual, 0f);
        }
        else if (girandoDerecha)
        {
            anguloActual = Mathf.MoveTowards(anguloActual, maxAngulo, velocidadGiro * Time.deltaTime);
            transform.localRotation = Quaternion.Euler(0f, anguloActual, 0f);
        }
        else
        {
            anguloActual = Mathf.MoveTowards(anguloActual, 0f, velocidadGiro * Time.deltaTime);
            transform.localRotation = Quaternion.Euler(0f, anguloActual, 0f);
        }
    }
}
