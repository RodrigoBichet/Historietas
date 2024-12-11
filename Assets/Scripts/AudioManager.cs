// using UnityEngine;

// public class AudioManager : MonoBehaviour
// {
//     public static AudioManager Instance { get; private set; }

//     public AudioSource audioSource;

//     void Awake()
//     {
//         if (Instance != null && Instance != this)
//         {
//             Destroy(gameObject);
//             return;
//         }

//         Instance = this;
//         DontDestroyOnLoad(gameObject);

//         audioSource = GetComponent<AudioSource>();
//     }

//     public void PlayAudio()
//     {
//         if (!audioSource.isPlaying)
//         {
//             audioSource.Play();
//         }
//     }

//     public void ToggleMute()
//     {
//         audioSource.mute = !audioSource.mute;
//     }
// }


using System.Collections;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    public AudioSource audioSource;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    public void ToggleMute()
    {
        audioSource.mute = !audioSource.mute;
    }

    // Função para pausar o áudio temporariamente
    public void PauseAudioTemporarily(float duration)
    {
        if (audioSource.isPlaying)
        {
            StartCoroutine(PauseAndResumeAudio(duration));
        }
    }

    private IEnumerator PauseAndResumeAudio(float duration)
    {
        audioSource.Pause(); // Pausa o áudio
        yield return new WaitForSeconds(duration); // Espera pelo tempo definido
        audioSource.UnPause(); // Retoma o áudio
    }
}
