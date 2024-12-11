using UnityEngine;
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
}
