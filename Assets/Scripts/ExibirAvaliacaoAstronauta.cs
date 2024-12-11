using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExibirAvaliacaoAstronauta : MonoBehaviour
{
    public GameObject imagemErro;
    public GameObject imagemQuase;
    public GameObject imagemAcerto;

    void Start()
    {
        if (GameManagerAstronauta.resultadoAvaliacao == "Acerto")
        {
            imagemAcerto.SetActive(true);
        }
        else if (GameManagerAstronauta.resultadoAvaliacao == "Quase")
        {
            imagemQuase.SetActive(true);
        }
        else if (GameManagerAstronauta.resultadoAvaliacao == "Erro")
        {
            imagemErro.SetActive(true);
        }

    }
}



