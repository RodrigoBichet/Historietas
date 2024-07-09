// using System.Collections;
// using UnityEngine;
// using UnityEngine.UI;

// public class DialogueControl : MonoBehaviour
// {
//     [Header("Components")]
//     public GameObject dialogueObj;
//     public Image profile;
//     public Text speechText;
//     public Text actorNameText;

//     [Header("Settings")]
//     public float typingSpeed;
//     private string[] sentences; // Privado
//     private int index; // Privado

//     public Button nextButton; // Referência ao botão de avançar
//     public Button backButton; // Referência ao botão de voltar

//     private Dialogue dialogueScript; // Referência ao script Dialogue

//     private void Start()
//     {
//         dialogueScript = FindObjectOfType<Dialogue>(); // Encontra o script Dialogue
//     }

//     public void Speech(Sprite p, string[] txt, string actorName)
//     {
//         dialogueObj.SetActive(true);
//         profile.sprite = p;
//         sentences = txt;
//         actorNameText.text = actorName;
//         nextButton.interactable = false; // Desativa o botão de avançar
//         backButton.interactable = false; // Desativa o botão de voltar
//         index = 0; // Resetar índice ao iniciar um novo diálogo
//         StartCoroutine(TypeSentence());
//     }

//     IEnumerator TypeSentence()
//     {
//         speechText.text = ""; // Garantir que o texto comece vazio
//         foreach (char letter in sentences[index].ToCharArray())
//         {
//             speechText.text += letter;
//             yield return new WaitForSeconds(typingSpeed);
//         }
//         nextButton.interactable = true; // Ativa o botão de avançar após imprimir o texto
//         backButton.interactable = (index > 0); // Ativa o botão de voltar se não estivermos no primeiro índice
//         Debug.Log("Acabou de escrever o texto: " + sentences[index]);
//     }

//     public void NextSentence()
//     {
//         if (speechText.text == sentences[index])
//         {
//             //ainda há textos
//             if (index < sentences.Length - 1)
//             {
//                 index++;
//                 speechText.text = "";
//                 nextButton.interactable = false; // Desativa o botão de avançar enquanto o texto está sendo impresso
//                 backButton.interactable = false; // Desativa o botão de voltar enquanto o texto está sendo impresso
//                 StartCoroutine(TypeSentence());
//                 Debug.Log("Próximo texto: " + sentences[index]);
//             }
//             else //quando acaba os textos
//             {
//                 speechText.text = "";
//                 index = 0;
//                 dialogueObj.SetActive(false);

//                 // Reativa o botão "AtiveDialogue"
//                 dialogueScript.EnableDialogueButton();

//                 Debug.Log("Acabou");
//             }
//         }
//     }

//     public void PreviousSentence(bool backButtonPressed = false)
//     {
//         if (index > 0)
//         {
//             index--;
//             speechText.text = "";
//             nextButton.interactable = false; // Desativa o botão de avançar enquanto o texto está sendo impresso
//             backButton.interactable = false; // Desativa o botão de voltar enquanto o texto está sendo impresso
//             StartCoroutine(TypeSentence());
//             Debug.Log("Texto anterior: " + sentences[index]);
//         }
//         else
//         {
//             Debug.Log("Este é o primeiro texto. Não há texto anterior.");
//         }

//         // Se o método foi chamado como resultado do botão de voltar, redefina o botão para falso
//         if (backButtonPressed)
//         {
//             nextButton.interactable = false;
//         }
//     }

//     public void ResetText()
//     {
//         // Reinicia o texto definindo o índice para zero
//         index = 0;
//         speechText.text = "";
//         StartCoroutine(TypeSentence());
//     }

//     // Métodos públicos para acessar index e sentences
//     public int GetIndex()
//     {
//         return index;
//     }

//     public string[] GetSentences()
//     {
//         return sentences;
//     }

//     // Método público para definir o índice (ajuste se necessário)
//     public void SetIndex(int newIndex)
//     {
//         if (newIndex >= 0 && newIndex < sentences.Length)
//         {
//             index = newIndex;
//             StartCoroutine(TypeSentence());
//         }
//         else
//         {
//             Debug.Log("Índice fora do alcance.");
//         }
//     }
// }

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{
    [Header("Components")]
    public GameObject dialogueObj;
    public Image profile;
    public Text speechText;
    public Text actorNameText;

    [Header("Settings")]
    public float typingSpeed;
    private string[] sentences; // Privado
    private int index; // Privado

    public Button nextButton; // Referência ao botão de avançar
    public Button backButton; // Referência ao botão de voltar

    private Dialogue dialogueScript; // Referência ao script Dialogue
    private ImageWithTime imageWithTimeScript; // Referência ao script ImageWithTime

    private void Start()
    {
        dialogueScript = FindObjectOfType<Dialogue>(); // Encontra o script Dialogue
        imageWithTimeScript = FindObjectOfType<ImageWithTime>(); // Encontra o script ImageWithTime
    }

    public void Speech(Sprite p, string[] txt, string actorName)
    {
        dialogueObj.SetActive(true);
        profile.sprite = p;
        sentences = txt;
        actorNameText.text = actorName;
        nextButton.interactable = false; // Desativa o botão de avançar
        backButton.interactable = false; // Desativa o botão de voltar
        index = 0; // Resetar índice ao iniciar um novo diálogo
        StartCoroutine(TypeSentence());
    }

    IEnumerator TypeSentence()
    {
        speechText.text = ""; // Garantir que o texto comece vazio
        foreach (char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        nextButton.interactable = true; // Ativa o botão de avançar após imprimir o texto
        backButton.interactable = (index > 0); // Ativa o botão de voltar se não estivermos no primeiro índice
        Debug.Log("Acabou de escrever o texto: " + sentences[index]);
    }

    public void NextSentence()
    {
        if (speechText.text == sentences[index])
        {
            //ainda há textos
            if (index < sentences.Length - 1)
            {
                index++;
                speechText.text = "";
                nextButton.interactable = false; // Desativa o botão de avançar enquanto o texto está sendo impresso
                backButton.interactable = false; // Desativa o botão de voltar enquanto o texto está sendo impresso
                StartCoroutine(TypeSentence());
                Debug.Log("Próximo texto: " + sentences[index]);
            }
            else //quando acaba os textos
            {
                speechText.text = "";
                index = 0;
                dialogueObj.SetActive(false);

                // Reativa o botão "AtiveDialogue"
                dialogueScript.EnableDialogueButton();

                // Desativa todas as imagens
                imageWithTimeScript.DeactivateAllImages();

                Debug.Log("Acabou");
            }
        }
    }

    public void PreviousSentence(bool backButtonPressed = false)
    {
        if (index > 0)
        {
            index--;
            speechText.text = "";
            nextButton.interactable = false; // Desativa o botão de avançar enquanto o texto está sendo impresso
            backButton.interactable = false; // Desativa o botão de voltar enquanto o texto está sendo impresso
            StartCoroutine(TypeSentence());
            Debug.Log("Texto anterior: " + sentences[index]);
        }
        else
        {
            Debug.Log("Este é o primeiro texto. Não há texto anterior.");
        }

        // Se o método foi chamado como resultado do botão de voltar, redefina o botão para falso
        if (backButtonPressed)
        {
            nextButton.interactable = false;
        }
    }

    public void ResetText()
    {
        // Reinicia o texto definindo o índice para zero
        index = 0;
        speechText.text = "";
        StartCoroutine(TypeSentence());
    }

    // Métodos públicos para acessar index e sentences
    public int GetIndex()
    {
        return index;
    }

    public string[] GetSentences()
    {
        return sentences;
    }

    // Método público para definir o índice (ajuste se necessário)
    public void SetIndex(int newIndex)
    {
        if (newIndex >= 0 && newIndex < sentences.Length)
        {
            index = newIndex;
            StartCoroutine(TypeSentence());
        }
        else
        {
            Debug.Log("Índice fora do alcance.");
        }
    }
}
