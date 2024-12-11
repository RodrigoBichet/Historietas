using UnityEngine;
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
}
