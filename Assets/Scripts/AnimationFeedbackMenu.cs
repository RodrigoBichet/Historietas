using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationFeedbackMenu : MonoBehaviour
{
    public void GoToSelectLevel()
    {
        PlayerPrefs.SetString("PreviousScene", "Menu"); // Define a origem como "Menu"
        SceneManager.LoadScene("SelectLevel");
    }
}