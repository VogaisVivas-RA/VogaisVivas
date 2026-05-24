using UnityEngine;
using UnityEngine.SceneManagement; // Biblioteca para trocar de telas

public class GerenciadorMenu : MonoBehaviour
{
    [Header("Configuração de Cenas")]
    [SerializeField] private string nomeDaCenaJogo = "SampleScene"; // Nome da cena da Iguana e RA

    [Header("Painéis do Menu")]
    [SerializeField] private GameObject painelSobre; // Painel que liga e desliga

    // 1. Função do Botão JOGAR
    public void Jogar()
    {
        SceneManager.LoadScene(nomeDaCenaJogo); // Carrega a cena de Realidade Aumentada
    }

    // 2. Função do Botão SOBRE (Para abrir a tela)
    public void AbrirSobre()
    {
        if (painelSobre != null)
        {
            painelSobre.SetActive(true); // Faz o painel aparecer
        }
    }

    // 3. Função do Botão VOLTAR
    public void VoltarParaMenu()
    {
        if (painelSobre != null)
        {
            painelSobre.SetActive(false); // Faz o painel sumir
        }
    }

    // 4. Função do Botão SAIR
    public void SairDoJogo()
    {
        Debug.Log("Sair do jogo clicado com sucesso!");
        Application.Quit(); // Fecha o app
    }
}