using UnityEngine;
public class GameManagerCoroa : MonoBehaviour
{
    public static GameManagerCoroa instance;

    public int errorCountCoroa = 0;
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
