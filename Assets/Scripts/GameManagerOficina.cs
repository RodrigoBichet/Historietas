using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerOficina : MonoBehaviour
{
    public static GameManagerOficina instance;

    public int errorCountOficina = 0;
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
        // Verifica se a cena carregada é "Fase04"
        if (scene.name == "Fase04")
        {
            // Zera o contador de erros
            errorCountOficina = 0;
        }
    }
}

