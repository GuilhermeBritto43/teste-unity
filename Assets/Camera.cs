using UnityEngine;
using UnityEngine.InputSystem;

public class CameraFollow : MonoBehaviour
{
    public Transform alvo;
    public float suavidade = 5f;

    private bool seguir = false;

    void Update()
    {
        if (Keyboard.current.kKey.wasPressedThisFrame)
        {
            seguir = !seguir; // alterna entre true e false
        }
    }

    void LateUpdate()
    {
        if (seguir && alvo != null)
        {
            Vector3 posicaoDesejada = new Vector3(alvo.position.x, alvo.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, posicaoDesejada, suavidade * Time.deltaTime);
        }
    }
}