using UnityEngine;
using UnityEngine.UI;

public class AudioTextManager : MonoBehaviour
{
    public AudioSource[] audioSources; // Array de AudioSources
    private int currentAudioIndex = 0; // Índice do áudio atualmente tocando
    public DialogueControl dialogueControl; // Referência ao DialogueControl

    void Start()
    {
        // Inicialmente desativa todos os AudioSources
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.enabled = false;
        }

        // Encontra o botão "AtiveDialogue" e adiciona o listener
        Button activateDialogueButton = GameObject.Find("AtiveDialogue").GetComponent<Button>();
        activateDialogueButton.onClick.AddListener(StartAudio);
    }

    private void StartAudio()
    {
        // Ativa e toca o primeiro áudio automaticamente
        if (audioSources.Length > 0 && audioSources[currentAudioIndex] != null)
        {
            audioSources[currentAudioIndex].enabled = true;
            audioSources[currentAudioIndex].Play();
            Debug.Log("Começou o áudio: " + currentAudioIndex);
        }
        else
        {
            Debug.Log("Nenhum áudio encontrado.");
        }
    }

    public void OnNextButtonPressed()
    {
        // Verifica se o texto atual foi completamente impresso
        if (dialogueControl.speechText.text == dialogueControl.GetSentences()[dialogueControl.GetIndex()])
        {
            PlayNextAudio();
            dialogueControl.NextSentence();
        }
        else
        {
            Debug.Log("Texto sendo escrito.");
        }
    }

    public void OnBackButtonPressed()
    {
        if (currentAudioIndex > 0)
        {
            int previousAudioIndex = currentAudioIndex - 1;
            audioSources[currentAudioIndex].Stop();
            Debug.Log("Parando áudio atual: " + currentAudioIndex);
            audioSources[previousAudioIndex].enabled = true;
            audioSources[previousAudioIndex].Play();
            Debug.Log("Reproduzindo áudio anterior: " + previousAudioIndex);
            currentAudioIndex = previousAudioIndex;

            dialogueControl.PreviousSentence();
        }
        else
        {
            Debug.Log("Este é o primeiro áudio. Não há áudio anterior.");
        }
    }

    public void OnAudioRepeatButtonPressed()
    {
        // Verifica se algum áudio está tocando
        if (!audioSources[currentAudioIndex].isPlaying)
        {
            audioSources[currentAudioIndex].Play();
            Debug.Log("Repetindo áudio atual: " + currentAudioIndex);
        }
        else
        {
            Debug.Log("Áudio já está tocando.");
        }
    }

    private void PlayNextAudio()
    {
        int nextAudioIndex = currentAudioIndex + 1;

        Debug.Log("Áudio atual index: " + currentAudioIndex + ", Próximo áudio index: " + nextAudioIndex);

        // Se o próximo índice exceder o tamanho do array, não tocará nenhum áudio
        if (nextAudioIndex >= audioSources.Length)
        {
            audioSources[currentAudioIndex].Stop();
            Debug.Log("Sem nenhum outro áudio. Parando áudio atual: " + currentAudioIndex);
            currentAudioIndex = nextAudioIndex; // Incrementa o índice para evitar toques adicionais
        }
        else
        {
            audioSources[currentAudioIndex].Stop();
            Debug.Log("Parando áudio atual: " + currentAudioIndex);

            audioSources[nextAudioIndex].enabled = true;
            audioSources[nextAudioIndex].Play();
            Debug.Log("Começando próximo áudio: " + nextAudioIndex);

            currentAudioIndex = nextAudioIndex;
        }
    }
}
