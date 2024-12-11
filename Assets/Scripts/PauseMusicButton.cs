using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMusicButton : MonoBehaviour
{
    public float pauseDuration = 5f; // Tempo de pausa em segundos (defina no Inspector)

    public void PauseMusic()
    {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.PauseAudioTemporarily(pauseDuration);
        }
    }
}