using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Sprite profile;
    public string[] speechText;
    public string actorName;

    private DialogueControl dc;
    public Button activateDialogueButton; // Referência ao botão "AtiveDialogue"

    private void Start()
    {
        dc = FindObjectOfType<DialogueControl>();

        // Associa o método ActivateDialogue ao clique no botão
        activateDialogueButton.onClick.AddListener(ActivateDialogue);
    }

    private void ActivateDialogue()
    {
        dc.Speech(profile, speechText, actorName);
        activateDialogueButton.interactable = false; // Desativa o botão após ser clicado
    }

    public void EnableDialogueButton()
    {
        activateDialogueButton.interactable = true; // Reativa o botão quando o diálogo é desativado
    }
}

