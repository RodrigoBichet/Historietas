using UnityEngine;
using UnityEngine.UI;

public class ExibirAvaliacaoCoroa : MonoBehaviour
{
    public GameObject imagemErro;
    public GameObject imagemQuase;
    public GameObject imagemAcerto;

    void Start()
    {
        if (GameManagerCoroa.resultadoAvaliacao == "Acerto")
        {
            imagemAcerto.SetActive(true);
        }
        else if (GameManagerCoroa.resultadoAvaliacao == "Quase")
        {
            imagemQuase.SetActive(true);
        }
        else if (GameManagerCoroa.resultadoAvaliacao == "Erro")
        {
            imagemErro.SetActive(true);
        }

    }
}
