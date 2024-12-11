using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationSelectLevelSelect : MonoBehaviour
{
    private Animator animator; // Referência ao Animator
    public float animationDuration = 2.0f; // Duração da animação (ajustável no Inspector)
    public string nextSceneName; // Nome da próxima cena, configurável no Inspector

    void Start()
    {
        // Obtém o componente Animator automaticamente
        animator = GetComponent<Animator>();

        // Garante que o Animator esteja desativado inicialmente
        if (animator != null)
        {
            animator.enabled = false;
        }
    }

    // Função para ativar a animação e trocar de cena com delay
    public void ActivateAndChangeScene()
    {
        if (animator != null)
        {
            animator.enabled = true; // Ativa o Animator, iniciando a animação
        }

        // Inicia a Coroutine para trocar de cena após o delay
        StartCoroutine(WaitAndChangeScene());
    }

    // Coroutine para aguardar a duração da animação antes de trocar de cena
    private IEnumerator WaitAndChangeScene()
    {
        yield return new WaitForSeconds(animationDuration); // Espera o tempo especificado

        // Verifica se o nome da próxima cena foi configurado
        if (!string.IsNullOrEmpty(nextSceneName))
        {
            SceneManager.LoadScene(nextSceneName); // Troca para a próxima cena pelo nome
        }
        else
        {
            Debug.LogError("O nome da próxima cena não foi configurado no Inspector.");
        }
    }
}