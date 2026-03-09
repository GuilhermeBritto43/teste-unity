using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem; // Necessário para o novo sistema

public class CuboScript : MonoBehaviour
{
    public float forcasPulo = 5f;
    private Rigidbody2D cu;
    public bool vivo = true;
    public bool estaNoChao = false;

    void Start()
    {
        cu = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // No novo sistema, Keyboard.current verifica o estado do teclado diretamente
        if (Keyboard.current.spaceKey.wasPressedThisFrame == true && vivo == true && estaNoChao == true)
        {
            cu.AddForce(Vector2.up * forcasPulo, ForceMode2D.Impulse);
            estaNoChao = false; 

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obstaculo"))
        {
            vivo = false;
        }
        if (collision.gameObject.CompareTag("chao"))
        {
            estaNoChao = true;
        }
    }

}
