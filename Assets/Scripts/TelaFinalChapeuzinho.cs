using UnityEngine;
using UnityEngine.UI;

public class TelaFinalChapeuzinho : MonoBehaviour
{
    public GameObject imagemErro;
    public GameObject imagemErroTitle;
    public GameObject imagemErroTitle2;
    public GameObject imagemQuase;
    public GameObject imagemQuase2;
    public GameObject imagemQuaseTitle;
    public GameObject imagemAcerto;
    public GameObject imagemAcerto2;
    public GameObject imagemAcerto3;

    public GameObject imagemAcertoTitle;
   

    void Start()
    {
        int errorCountChapeuzinho = GameManagerChapeuzinho.instance.errorCountChapeuzinho;

        if (errorCountChapeuzinho == 0)
        {
            imagemAcerto.SetActive(true);
            imagemAcerto2.SetActive(true);
            imagemAcerto3.SetActive(true);
            imagemAcertoTitle.SetActive(true);
           
            GameManagerChapeuzinho.resultadoAvaliacao = "Acerto";
        }
        else if (errorCountChapeuzinho <= 4)
        {
            imagemQuase.SetActive(true);
            imagemQuase2.SetActive(true);
            imagemQuaseTitle.SetActive(true);
            GameManagerChapeuzinho.resultadoAvaliacao = "Quase";

        }
        else
        {
            imagemErro.SetActive(true);
            imagemErroTitle.SetActive(true);
            imagemErroTitle2.SetActive(true);
            GameManagerChapeuzinho.resultadoAvaliacao = "Erro";
        }
    }

    public void ButtonReset()
    {
        GameManagerChapeuzinho.instance.errorCountChapeuzinho = 0; // Reseta a contagem de erros
    }
}
