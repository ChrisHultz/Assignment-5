using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordDelete : MonoBehaviour {
    public Canvas canvas;
    public WordManager wordManager;
    private float minYPosition = -300f;
    public Text livestxt;
    public AudioSource audioSource;
    public static int lives = 5;
    private int carryOver;

    void Update() {
        livestxt.text = "Lives: " + lives;
        for (int i = 0; i < wordManager.words.Count; i++) {
            Word word = wordManager.words[i];
            RectTransform rectTransform = word.wordDisplay.text.GetComponent<RectTransform>();
            if (rectTransform.anchoredPosition.y < minYPosition) {
                if (lives > 1) {
                    carryOver = lives;
                    wordManager.RemoveWord(word); // Use the new RemoveWord method
                    Destroy(word.wordDisplay.gameObject);
                    i--;
                    audioSource.Play();
                    carryOver--;
                    lives = carryOver;
                }
                else {
                    wordManager.RemoveWord(word); // Use the new RemoveWord method
                    Destroy(word.wordDisplay.gameObject);
                    i--;
                    carryOver--;
                    lives = carryOver;
                    SceneManager.LoadScene("Exit");
                    lives = 5;
                }
            }
        }
    }
}
