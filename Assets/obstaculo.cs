using UnityEngine;

public class obstaculo : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Logica.MoverParaEsquerda(transform);
    }
}
