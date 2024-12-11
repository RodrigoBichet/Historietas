using UnityEngine;
using UnityEngine.UI;

public class TelaFinalAstronauta : MonoBehaviour
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
        int errorCountAstronauta = GameManagerAstronauta.instance.errorCountAstronauta;

        if (errorCountAstronauta == 0)
        {
            imagemAcerto.SetActive(true);
            imagemAcerto2.SetActive(true);
            imagemAcerto3.SetActive(true);
            imagemAcertoTitle.SetActive(true);
            imagemAcertoConfete1.SetActive(true);
            imagemAcertoConfete2.SetActive(true);
            GameManagerAstronauta.resultadoAvaliacao = "Acerto";
        }
        else if (errorCountAstronauta <= 4)
        {
            imagemQuase.SetActive(true);
            imagemQuase2.SetActive(true);
            imagemQuaseTitle.SetActive(true);
            GameManagerAstronauta.resultadoAvaliacao = "Quase";

        }
        else
        {
            imagemErro.SetActive(true);
            imagemErroTitle.SetActive(true);
            imagemErroTitle2.SetActive(true);
            GameManagerAstronauta.resultadoAvaliacao = "Erro";
        }
    }

    public void ButtonReset()
    {
        GameManagerAstronauta.instance.errorCountAstronauta = 0; // Reseta a contagem de erros
    }
}
