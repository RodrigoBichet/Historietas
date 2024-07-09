using UnityEngine;
using UnityEngine.UI;

public class ExibirAvaliacao : MonoBehaviour
{
    public GameObject imagemErro;
    public GameObject imagemQuase;
    public GameObject imagemAcerto;

    void Start()
    {
        if (GameManager.resultadoAvaliacao == "Acerto")
        {
            imagemAcerto.SetActive(true);
        }
        else if (GameManager.resultadoAvaliacao == "Quase")
        {
            imagemQuase.SetActive(true);
        }
        else if (GameManager.resultadoAvaliacao == "Erro")
        {
            imagemErro.SetActive(true);
        }
    }
}
