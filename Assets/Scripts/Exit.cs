using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour {
    public Text userTxt;
    public Text StatisticsTxt;

    void Awake() {
        float percentright = ((float) WordManager.CorrectTyped) / ((float) WordInput.CountTyped) * 100;
        string percentrightStr = percentright.ToString("0.0");
        userTxt.text = Intro.pass.ToUpper();

        StatisticsTxt.text = "Words used: " + WordManager.WordsUsed + "\n" +
        "Number of characters typed: " + WordInput.CountTyped + "\n" +
        "Number of characters typed correctly: " + WordManager.CorrectTyped + "\n" +
        "Percentage Correct: " + percentrightStr + "%";

    }

    public void PlayGame() {
        SceneManager.LoadScene("Main");
        WordDelete.lives = 5;
        WordManager.WordsUsed = 0;
        WordInput.CountTyped = 0;
        WordManager.CorrectTyped = 0;

    }
    public void BackToMenu() {
        SceneManager.LoadScene("Intro");
        WordDelete.lives = 5;
        WordManager.WordsUsed = 0;
        WordInput.CountTyped = 0;
        WordManager.CorrectTyped = 0;
    }
    public void QuitGame() {
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("I quit...");
    }
}
