using UnityEngine;
using UnityEngine.UI;

public class ExibirAvaliacaoFazenda : MonoBehaviour
{
    public GameObject imagemErro;
    public GameObject imagemQuase;
    public GameObject imagemAcerto;

    void Start()
    {
        if (GameManagerFazenda.resultadoAvaliacao == "Acerto")
        {
            imagemAcerto.SetActive(true);
        }
        else if (GameManagerFazenda.resultadoAvaliacao == "Quase")
        {
            imagemQuase.SetActive(true);
        }
        else if (GameManagerFazenda.resultadoAvaliacao == "Erro")
        {
            imagemErro.SetActive(true);
        }

    }
}
