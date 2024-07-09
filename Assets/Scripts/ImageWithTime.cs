// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class ImageWithTime : MonoBehaviour
// {
//     public GameObject[] images; // Array de imagens que serão ativadas
//     public float[] activationIntervals; // Array de intervalos de tempo para cada imagem

//     private void Start()
//     {
//         // Verifica se os arrays têm o mesmo comprimento
//         if (images.Length != activationIntervals.Length)
//         {
//             Debug.LogError("Os arrays 'images' e 'activationIntervals' devem ter o mesmo comprimento.");
//             return;
//         }

//         // Inicialmente desativa todas as imagens
//         foreach (GameObject image in images)
//         {
//             image.SetActive(false);
//         }

//         // Encontra o botão "AtiveDialogue" e adiciona o listener
//         Button activateDialogueButton = GameObject.Find("AtiveDialogue").GetComponent<Button>();
//         activateDialogueButton.onClick.AddListener(StartImageActivation);
//     }

//     private void StartImageActivation()
//     {
//         // Inicia a coroutine que ativa as imagens em intervalos de tempo
//         StartCoroutine(ActivateImages());
//     }

//     private IEnumerator ActivateImages()
//     {
//         for (int i = 0; i < images.Length; i++)
//         {
//             yield return new WaitForSeconds(activationIntervals[i]);
//             images[i].SetActive(true);
//         }
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageWithTime : MonoBehaviour
{
    public GameObject[] images; // Array de imagens que serão ativadas
    public float[] activationIntervals; // Array de intervalos de tempo para cada imagem

    private void Start()
    {
        // Verifica se os arrays têm o mesmo comprimento
        if (images.Length != activationIntervals.Length)
        {
            Debug.LogError("Os arrays 'images' e 'activationIntervals' devem ter o mesmo comprimento.");
            return;
        }

        // Inicialmente desativa todas as imagens
        foreach (GameObject image in images)
        {
            image.SetActive(false);
        }

        // Encontra o botão "AtiveDialogue" e adiciona o listener
        Button activateDialogueButton = GameObject.Find("AtiveDialogue").GetComponent<Button>();
        activateDialogueButton.onClick.AddListener(StartImageActivation);
    }

    private void StartImageActivation()
    {
        // Inicia a coroutine que ativa as imagens em intervalos de tempo
        StartCoroutine(ActivateImages());
    }

    private IEnumerator ActivateImages()
    {
        for (int i = 0; i < images.Length; i++)
        {
            yield return new WaitForSeconds(activationIntervals[i]);
            images[i].SetActive(true);
        }
    }

    public void DeactivateAllImages()
    {
        foreach (GameObject image in images)
        {
            image.SetActive(false);
        }
    }
}
