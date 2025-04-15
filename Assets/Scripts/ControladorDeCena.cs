using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorDeCena : MonoBehaviour
{
    public Button botaoAvancar;
    public Button botaoHistoria;
    public AudioSource audioHistoria;

    private bool audioComecou = false;
    private bool audioConcluido = false;

    void Start()
    {
        // Botão de avançar continua visível, mas desativado
        botaoAvancar.interactable = false;

        // Adiciona evento ao botão da história
        botaoHistoria.onClick.AddListener(IniciarHistoria);
    }

    void Update()
    {
        // Verifica se o áudio já começou, terminou, e ainda não marcamos como concluído
        if (audioComecou && !audioHistoria.isPlaying && !audioConcluido)
        {
            audioConcluido = true;
            LiberarAvanco();
        }
    }

    void IniciarHistoria()
    {
        if (audioHistoria != null)
        {
            audioHistoria.Play();
            audioComecou = true;

            // Impede múltiplos cliques no botão de história
            botaoHistoria.interactable = false;
        }
    }

    void LiberarAvanco()
    {
        botaoAvancar.interactable = true;
    }

    // Função para trocar de cena (usar no botão de avançar)
    public void AvancarCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }
}
