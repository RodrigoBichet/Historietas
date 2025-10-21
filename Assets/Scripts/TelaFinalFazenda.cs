using UnityEngine;
using UnityEngine.UI;

public class TelaFinalFazenda : MonoBehaviour
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
        int errorCountFazenda = GameManagerFazenda.instance.errorCountFazenda;

        if (errorCountFazenda == 0)
        {
            imagemAcerto.SetActive(true);
            imagemAcerto2.SetActive(true);
            imagemAcerto3.SetActive(true);
            imagemAcertoTitle.SetActive(true);
            
            GameManagerFazenda.resultadoAvaliacao = "Acerto";
        }
        else if (errorCountFazenda <= 4)
        {
            imagemQuase.SetActive(true);
            imagemQuase2.SetActive(true);
            imagemQuaseTitle.SetActive(true);
            GameManagerFazenda.resultadoAvaliacao = "Quase";

        }
        else
        {
            imagemErro.SetActive(true);
            imagemErroTitle.SetActive(true);
            imagemErroTitle2.SetActive(true);
            GameManagerFazenda.resultadoAvaliacao = "Erro";
        }
    }

    public void ButtonReset()
    {
        GameManagerFazenda.instance.errorCountFazenda = 0; // Reseta a contagem de erros
    }
}
