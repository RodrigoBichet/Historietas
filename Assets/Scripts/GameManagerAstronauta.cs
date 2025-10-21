using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerAstronauta : MonoBehaviour
{
    public static GameManagerAstronauta instance;

    public int errorCountAstronauta = 0;
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
        // Verifica se a cena carregada é "Fase02"
        if (scene.name == "Fase02")
        {
            // Zera o contador de erros
            errorCountAstronauta = 0;
        }
    }
}

