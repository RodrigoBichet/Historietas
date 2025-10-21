using UnityEngine;
using UnityEngine.UI;

public class TelaFinalBanda : MonoBehaviour
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
        int errorCountBanda = GameManagerBanda.instance.errorCountBanda;

        if (errorCountBanda == 0)
        {
            imagemAcerto.SetActive(true);
            imagemAcerto2.SetActive(true);
            imagemAcerto3.SetActive(true);
            imagemAcertoTitle.SetActive(true);
           
            GameManagerBanda.resultadoAvaliacao = "Acerto";
        }
        else if (errorCountBanda <= 4)
        {
            imagemQuase.SetActive(true);
            imagemQuase2.SetActive(true);
            imagemQuaseTitle.SetActive(true);
            GameManagerBanda.resultadoAvaliacao = "Quase";

        }
        else
        {
            imagemErro.SetActive(true);
            imagemErroTitle.SetActive(true);
            imagemErroTitle2.SetActive(true);
            GameManagerBanda.resultadoAvaliacao = "Erro";
        }
    }

    public void ButtonReset()
    {
        GameManagerBanda.instance.errorCountBanda = 0; // Reseta a contagem de erros
    }
}
