using UnityEngine;
using UnityEngine.UI;

public class ExibirAvaliacaoBanda : MonoBehaviour
{
    public GameObject imagemErro;
    public GameObject imagemQuase;
    public GameObject imagemAcerto;

    void Start()
    {
        if (GameManagerBanda.resultadoAvaliacao == "Acerto")
        {
            imagemAcerto.SetActive(true);
        }
        else if (GameManagerBanda.resultadoAvaliacao == "Quase")
        {
            imagemQuase.SetActive(true);
        }
        else if (GameManagerBanda.resultadoAvaliacao == "Erro")
        {
            imagemErro.SetActive(true);
        }

    }
}
