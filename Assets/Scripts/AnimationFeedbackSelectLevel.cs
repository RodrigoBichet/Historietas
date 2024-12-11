using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationFeedbackSelectLevel : MonoBehaviour
{
    public GameObject animatedObject1;
    public GameObject animatedObject2;
    public GameObject animatedObject3;
    public GameObject animatedObject4;
    public GameObject animatedObject5;
    public GameObject animatedObject6;
    public GameObject animatedObject7;
    public GameObject animatedObject8;
    public GameObject animatedObject9;
    public GameObject animatedObject10;
    public GameObject animatedObject11;
    public GameObject animatedObject12;
    public GameObject animatedObject13;
    public GameObject animatedObject14;
    public GameObject animatedObject15;
    void Start()
    {
        string previousScene = PlayerPrefs.GetString("PreviousScene", "");

        // Se veio do menu, desative a animação
        if (previousScene == "Menu")
        {
            animatedObject1.GetComponent<Animator>().enabled = false; // Desativa a animação
            animatedObject2.GetComponent<Animator>().enabled = false; // Desativa a animação
            animatedObject3.GetComponent<Animator>().enabled = false; // Desativa a animação
            animatedObject4.GetComponent<Animator>().enabled = false; // Desativa a animação
            animatedObject5.GetComponent<Animator>().enabled = false; // Desativa a animação
            animatedObject6.GetComponent<Animator>().enabled = false; // Desativa a animação
            animatedObject7.GetComponent<Animator>().enabled = false; // Desativa a animação
            animatedObject8.GetComponent<Animator>().enabled = false; // Desativa a animação
            animatedObject9.GetComponent<Animator>().enabled = false; // Desativa a animação
            animatedObject10.GetComponent<Animator>().enabled = false; // Desativa a animação
            animatedObject11.GetComponent<Animator>().enabled = false; // Desativa a animação
            animatedObject12.GetComponent<Animator>().enabled = false; // Desativa a animação
            animatedObject13.GetComponent<Animator>().enabled = false; // Desativa a animação
            animatedObject14.GetComponent<Animator>().enabled = false; // Desativa a animação
            animatedObject15.GetComponent<Animator>().enabled = false; // Desativa a animação
        }

        // Redefine a origem para evitar que afete futuras transições
        PlayerPrefs.SetString("PreviousScene", "SelectLevel");
    }
}
