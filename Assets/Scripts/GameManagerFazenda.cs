using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerFazenda : MonoBehaviour
{
    public static GameManagerFazenda instance;

    public int errorCountFazenda = 0;
    public static string resultadoAvaliacao; // Variável estática para armazenar o resultado

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void OnEnable()
    {
        // Inscreve-se para ouvir o evento de carregamento de cena
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        // Remove-se da inscrição do evento de carregamento de cena
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Verifica se a cena carregada é "Fase05"
        if (scene.name == "Fase05")
        {
            // Zera o contador de erros
            errorCountFazenda = 0;
        }
    }
}

