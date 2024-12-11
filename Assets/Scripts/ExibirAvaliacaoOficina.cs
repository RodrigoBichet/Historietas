using UnityEngine;
using UnityEngine.UI;

public class ExibirAvaliacaoOficina : MonoBehaviour
{
    public GameObject imagemErro;
    public GameObject imagemQuase;
    public GameObject imagemAcerto;

    void Start()
    {
        if (GameManagerOficina.resultadoAvaliacao == "Acerto")
        {
            imagemAcerto.SetActive(true);
        }
        else if (GameManagerOficina.resultadoAvaliacao == "Quase")
        {
            imagemQuase.SetActive(true);
        }
        else if (GameManagerOficina.resultadoAvaliacao == "Erro")
        {
            imagemErro.SetActive(true);
        }

    }
}
