using UnityEngine;
using UnityEngine.UI;

public class TelaFinalCoroa : MonoBehaviour
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
        int errorCountCoroa = GameManagerCoroa.instance.errorCountCoroa;

        if (errorCountCoroa == 0)
        {
            imagemAcerto.SetActive(true);
            imagemAcerto2.SetActive(true);
            imagemAcerto3.SetActive(true);
            imagemAcertoTitle.SetActive(true);
         
            GameManagerCoroa.resultadoAvaliacao = "Acerto";
        }
        else if (errorCountCoroa <= 4)
        {
            imagemQuase.SetActive(true);
            imagemQuase2.SetActive(true);
            imagemQuaseTitle.SetActive(true);
            GameManagerCoroa.resultadoAvaliacao = "Quase";

        }
        else
        {
            imagemErro.SetActive(true);
            imagemErroTitle.SetActive(true);
            imagemErroTitle2.SetActive(true);
            GameManagerCoroa.resultadoAvaliacao = "Erro";
        }
    }

    public void ButtonReset()
    {
        GameManagerCoroa.instance.errorCountCoroa = 0; // Reseta a contagem de erros
    }
}
