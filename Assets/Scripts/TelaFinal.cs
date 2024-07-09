using UnityEngine;
using UnityEngine.UI;

public class TelaFinal : MonoBehaviour
{
    public GameObject imagemErro;
    public GameObject imagemErroTitle;
    public GameObject imagemQuase;
    public GameObject imagemQuaseTitle;
    public GameObject imagemAcerto;
    public GameObject imagemAcertoTitle;
    
    void Start()
    {
        int errorCount = GameManager.instance.errorCount;

        if (errorCount == 0)
        {
            imagemAcerto.SetActive(true);
            imagemAcertoTitle.SetActive(true);
            GameManager.resultadoAvaliacao = "Acerto";
        }
        else if (errorCount <= 4)
        {
            imagemQuase.SetActive(true);
            imagemQuaseTitle.SetActive(true);
            GameManager.resultadoAvaliacao = "Quase";
            
        }
        else
        {
            imagemErro.SetActive(true);
            imagemErroTitle.SetActive(true);
            GameManager.resultadoAvaliacao = "Erro";
        }
    }

    public void ButtonReset()
    {
        GameManager.instance.errorCount = 0; // Reseta a contagem de erros
    }  
}
