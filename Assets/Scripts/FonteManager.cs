using UnityEngine;
using UnityEngine.UI;

public class FonteManager : MonoBehaviour
{
    [Header("Botões de seleção")]
    public Button btnMaiuscula;
    public Button btnMinuscula;

    [Header("Imagens de estado")]
    public GameObject imgMaiusculaAtiva;
    public GameObject imgMaiusculaInativa;
    public GameObject imgMinusculaAtiva;
    public GameObject imgMinusculaInativa;

    private const string PREF_KEY = "FonteMaiuscula"; 

    void Start()
    {
        // Carrega o estado salvo
        bool isMaiuscula = PlayerPrefs.GetInt(PREF_KEY, 1) == 1;
        AtualizarInterface(isMaiuscula);

        // Adiciona listeners
        btnMaiuscula.onClick.AddListener(() => TrocarFonte(true));
        btnMinuscula.onClick.AddListener(() => TrocarFonte(false));
    }

    private void TrocarFonte(bool maiuscula)
    {
        PlayerPrefs.SetInt(PREF_KEY, maiuscula ? 1 : 0);
        PlayerPrefs.Save();
        AtualizarInterface(maiuscula);
    }

    private void AtualizarInterface(bool maiuscula)
    {
        
        imgMaiusculaAtiva.SetActive(maiuscula);
        imgMaiusculaInativa.SetActive(!maiuscula);
        imgMinusculaAtiva.SetActive(!maiuscula);
        imgMinusculaInativa.SetActive(maiuscula);
    }

    
    public static bool IsMaiuscula()
    {
        return PlayerPrefs.GetInt(PREF_KEY, 1) == 1;
    }
}
