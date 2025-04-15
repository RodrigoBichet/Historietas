using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButtonRedirect : MonoBehaviour
{
    public Button playButton;

    private const string primeiraVezKey = "JaEntrouNoJogo"; // Chave usada no PlayerPrefs

    void Start()
    {
        if (playButton != null)
        {
            playButton.onClick.AddListener(VerificarDestino);
        }
        else
        {
            Debug.LogWarning("Botão Play não está atribuído no inspector!");
        }
    }

    void VerificarDestino()
    {
        if (!PlayerPrefs.HasKey(primeiraVezKey))
        {
            // Primeira vez: marca como já entrou e vai para o tutorial
            PlayerPrefs.SetInt(primeiraVezKey, 1);
            PlayerPrefs.Save();

            SceneManager.LoadScene("Tutorial");
        }
        else
        {
            // Já entrou antes: segue para seleção de fases normalmente
            SceneManager.LoadScene("Selectlevel");
        }
    }
}
