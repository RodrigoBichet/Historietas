using UnityEngine;
using UnityEngine.UI;

public class ExibirAvaliacaoChapeuzinho : MonoBehaviour
{
    public GameObject imagemErro;
    public GameObject imagemQuase;
    public GameObject imagemAcerto;

    void Start()
    {
        if (GameManagerChapeuzinho.resultadoAvaliacao == "Acerto")
        {
            imagemAcerto.SetActive(true);
        }
        else if (GameManagerChapeuzinho.resultadoAvaliacao == "Quase")
        {
            imagemQuase.SetActive(true);
        }
        else if (GameManagerChapeuzinho.resultadoAvaliacao == "Erro")
        {
            imagemErro.SetActive(true);
        }

    }
}
