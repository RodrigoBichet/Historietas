// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.Video;
// using UnityEngine.SceneManagement; // Adicionando o namespace para gerenciamento de cena

// public class ButtonTutorial : MonoBehaviour
// {
//     public Button botao;
//     public VideoPlayer videoPlayer;
//     public GameObject screenObject;




//     private AudioManager audioManager; // Referência para o AudioManager na cena Menu

//     private bool videoPlaying = false; // Variável para controlar se o vídeo está tocando

//     void Start()
//     {
//         videoPlayer.loopPointReached += OnVideoEnd;
//         videoPlayer.gameObject.SetActive(false);
//         screenObject.SetActive(false);



//         botao.onClick.AddListener(AtivarVideoPlayer);

//         // Procura o AudioManager na cena Menu
//         audioManager = FindObjectOfType<AudioManager>();
//     }

//     void AtivarVideoPlayer()
//     {
//         // Pausa a música de fundo se o AudioManager for encontrado
//         if (audioManager != null)
//         {
//             audioManager.ToggleMute();
//         }

//         videoPlayer.gameObject.SetActive(true);
//         screenObject.SetActive(true);



//         videoPlayer.Play();

//         videoPlaying = true; // Marca que o vídeo está tocando
//     }

//     void OnVideoEnd(VideoPlayer vp)
//     {
//         // Desativa os elementos quando o vídeo termina
//         videoPlayer.gameObject.SetActive(false);
//         screenObject.SetActive(false);



//         // Retoma a música de fundo apenas se o vídeo estiver tocando e o AudioManager for encontrado
//         if (videoPlaying && audioManager != null)
//         {
//             audioManager.ToggleMute();
//         }

//         videoPlaying = false; // Marca que o vídeo não está mais tocando
//     }

//     void OnDestroy()
//     {
//         // Se o script for destruído (como durante a troca de cena), retoma a música de fundo apenas se o vídeo estiver tocando e o AudioManager for encontrado
//         if (videoPlaying && audioManager != null)
//         {
//             audioManager.ToggleMute();
//         }
//     }
// }

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ButtonTutorial : MonoBehaviour
{
    public Button botao;
    public VideoPlayer videoPlayer;
    public GameObject screenObject;

    public Image backgroundImage; // Novo campo para atribuir o BackgroundSquare

    private Color corOriginal; // Para guardar a cor original e restaurar depois, se quiser
    private AudioManager audioManager;
    private bool videoPlaying = false;

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
        videoPlayer.gameObject.SetActive(false);
        screenObject.SetActive(false);

        botao.onClick.AddListener(AtivarVideoPlayer);
        audioManager = FindObjectOfType<AudioManager>();

        // Salvando a cor original do background
        if (backgroundImage != null)
        {
            corOriginal = backgroundImage.color;
            Debug.Log("Cor original salva: " + corOriginal);
        }
    }

    void AtivarVideoPlayer()
    {
        if (audioManager != null)
        {
            audioManager.ToggleMute();
        }

        videoPlayer.gameObject.SetActive(true);
        screenObject.SetActive(true);
        videoPlayer.Play();
        videoPlaying = true;

        // Alterando o alpha do background
        if (backgroundImage != null)
        {
            Color fadedColor = backgroundImage.color;
            fadedColor.a = 100f / 255f; // Ou 0.78f
            backgroundImage.color = fadedColor;
            Debug.Log("Background alterado para alpha 200");
        }
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        videoPlayer.gameObject.SetActive(false);
        screenObject.SetActive(false);

        if (videoPlaying && audioManager != null)
        {
            audioManager.ToggleMute();
        }

        videoPlaying = false;

        // (Opcional) Restaurar a cor original
        if (backgroundImage != null)
        {
            backgroundImage.color = corOriginal;
            Debug.Log("Cor original restaurada");
        }
    }

    void OnDestroy()
    {
        if (videoPlaying && audioManager != null)
        {
            audioManager.ToggleMute();
        }
    }
}
