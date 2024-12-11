using UnityEngine;
using UnityEngine.UI;

public class TelaFinalOficina : MonoBehaviour
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
    public GameObject imagemAcertoConfete1;
    public GameObject imagemAcertoConfete2;

    void Start()
    {
        int errorCountOficina = GameManagerOficina.instance.errorCountOficina;

        if (errorCountOficina == 0)
        {
            imagemAcerto.SetActive(true);
            imagemAcerto2.SetActive(true);
            imagemAcerto3.SetActive(true);
            imagemAcertoTitle.SetActive(true);
            imagemAcertoConfete1.SetActive(true);
            imagemAcertoConfete2.SetActive(true);
            GameManagerOficina.resultadoAvaliacao = "Acerto";
        }
        else if (errorCountOficina <= 4)
        {
            imagemQuase.SetActive(true);
            imagemQuase2.SetActive(true);
            imagemQuaseTitle.SetActive(true);
            GameManagerOficina.resultadoAvaliacao = "Quase";

        }
        else
        {
            imagemErro.SetActive(true);
            imagemErroTitle.SetActive(true);
            imagemErroTitle2.SetActive(true);
            GameManagerOficina.resultadoAvaliacao = "Erro";
        }
    }

    public void ButtonReset()
    {
        GameManagerOficina.instance.errorCountOficina = 0; // Reseta a contagem de erros
    }
}
