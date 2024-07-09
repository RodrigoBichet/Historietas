// using UnityEngine;
// using UnityEngine.UI;

// public class TelaFinal : MonoBehaviour
// {
//     public GameObject imagemErro;
//     public GameObject imagemQuase;
//     public GameObject imagemAcerto;

//     void Start()
//     {
//         int errorCount = GameManager.instance.errorCount;

//         if (errorCount == 0)
//         {
//             imagemAcerto.SetActive(true);
//         }
//         else if (errorCount <= 4)
//         {
//             imagemQuase.SetActive(true);
//         }
//         else
//         {
//             imagemErro.SetActive(true);
//         }
//     }

//     public void ButtonReset()
//     {
//         GameManager.instance.errorCount = 0; // Reseta a contagem de erros
//     }
// }

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Adicione esta linha para usar o SceneManager

public class TelaFinal : MonoBehaviour
{
    public GameObject imagemErro;
    public GameObject imagemQuase;
    public GameObject imagemAcerto;

    void Start()
    {
        int errorCount = GameManager.instance.errorCount;

        if (errorCount == 0)
        {
            imagemAcerto.SetActive(true);
            GameManager.resultadoAvaliacao = "Acerto";
        }
        else if (errorCount <= 4)
        {
            imagemQuase.SetActive(true);
            GameManager.resultadoAvaliacao = "Quase";
        }
        else
        {
            imagemErro.SetActive(true);
            GameManager.resultadoAvaliacao = "Erro";
        }
    }

    public void ButtonReset()
    {
        GameManager.instance.errorCount = 0; // Reseta a contagem de erros
    }

    // public void LoadNextScene(string sceneName)
    // {
    //     SceneManager.LoadScene(sceneName);
    // }
}
