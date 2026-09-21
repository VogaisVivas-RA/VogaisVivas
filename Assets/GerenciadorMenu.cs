using UnityEngine;
using UnityEngine.SceneManagement; // Biblioteca para trocar de telas

public class GerenciadorMenu : MonoBehaviour
{
    [Header("Configuração de Cenas")]
    [SerializeField] private string nomeDaCenaJogo = "SampleScene"; // Nome da cena da Iguana e RA

    [Header("Painéis do Menu")]
    [SerializeField] private GameObject painelSobre; // Painel com os créditos e pequeno botão
    [SerializeField] private GameObject painelInstrucoes; // Novo painel com botão de download

    // --- FUNÇÃO DO BOTÃO JOGAR ---
    public void Jogar()
    {
        SceneManager.LoadScene(nomeDaCenaJogo); // Carrega a cena de Realidade Aumentada
    }

    // --- FUNÇÕES DO PAINEL SOBRE (Botão pequeno com ícone) ---
    public void AbrirSobre()
    {
        if (painelSobre != null) painelSobre.SetActive(true); 
    }

    public void FecharSobre()
    {
        if (painelSobre != null) painelSobre.SetActive(false); 
    }

    // --- FUNÇÕES DO PAINEL INSTRUÇÕES (Botão Azul) ---
    public void AbrirInstrucoes()
    {
        if (painelInstrucoes != null) painelInstrucoes.SetActive(true); 
    }

    public void FecharInstrucoes()
    {
        if (painelInstrucoes != null) painelInstrucoes.SetActive(false); 
    }

 // --- FUNÇÃO DO BOTÃO DE DOWNLOAD (Dentro das Instruções) ---
    public void AbrirLinkMarcadores()
    {
        // Link direto do GitHub (Raw) que aponta para o repositório público do Vogais Vivas
        string linkDownload = "https://raw.githubusercontent.com/FelipeDias77/VogaisVivas/main/Assets/Documentos/marcadores_vogais.pdf";
        
        Debug.Log("A descarregar o PDF dos marcadores diretamente do GitHub...");
        Application.OpenURL(linkDownload); 
    }

    // --- FUNÇÃO DO BOTÃO SAIR ---
    public void SairDoJogo()
    {
        Debug.Log("Sair do jogo clicado com sucesso!");
        Application.Quit(); // Fecha o app no celular
    }
}