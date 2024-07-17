using UnityEngine;
public class GameManagerAcao : MonoBehaviour
{
    public static GameManagerAcao instance;

    public int errorCount = 0;
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
}
