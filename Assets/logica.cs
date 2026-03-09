using UnityEngine;

public class Logica
{
    public static void MoverParaEsquerda(Transform obj)
    {
        obj.Translate(Vector3.left * 10 * Time.deltaTime);
    }
}