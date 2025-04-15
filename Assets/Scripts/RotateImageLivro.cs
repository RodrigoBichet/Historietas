using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RotateImageLivro : MonoBehaviour
{
    private Animator animator;
    private bool animacaoAtiva = true;

    public Button botaoReferencia; // ← arraste aqui o botão que desativa após o clique

    void Start()
    {
        animator = GetComponent<Animator>();

        if (botaoReferencia != null)
        {
            InvokeRepeating("AlternarAnimacao", 0, 3);
        }
        else
        {
            Debug.LogWarning("Botão de referência não atribuído em RotateImage.");
        }
    }

    void AlternarAnimacao()
    {
        if (botaoReferencia != null && !botaoReferencia.interactable)
        {
            // Botão desativado: para a animação e cancela o ciclo
            CancelInvoke("AlternarAnimacao");
            if (animator != null)
            {
                animator.enabled = false;
            }
            return;
        }

        if (gameObject.activeInHierarchy && animator != null && animator.isActiveAndEnabled)
        {
            if (!DragDrop.coloucerto)
            {
                animacaoAtiva = !animacaoAtiva;

                if (animacaoAtiva)
                {
                    animator.Play("AnimationRotate", 0, 0); // Troque pelo nome da sua animação se for diferente
                }
                else
                {
                    animator.StopPlayback();
                }
            }
        }
    }
}
