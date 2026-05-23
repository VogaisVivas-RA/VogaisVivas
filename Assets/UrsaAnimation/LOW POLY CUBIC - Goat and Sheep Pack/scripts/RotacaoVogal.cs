using UnityEngine;

public class RotacaoVogal : MonoBehaviour
{
    // Controla a velocidade do passeio da ovelha ao redor da letra
    public float velocidade = 40f;

    void Update()
    {
        // Gira o pivô central no eixo Y (vertical), fazendo a ovelha orbitar
        transform.Rotate(0, velocidade * Time.deltaTime, 0);
    }
}