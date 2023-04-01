using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour {
    private bool isPaused = false;
    public GameObject objectToDisable;
    public Text PlayerName;
    public Text pauseText;

    public void Awake() {
        PlayerName.text = Intro.pass;
    }


    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(isPaused) {
                pauseText.enabled = false;
                ResumeGame();
            }
            else {
                pauseText.enabled = true;
                Pause();
            }
        }
        if (!isPaused) {
            pauseText.text = "Game is paused";
        }
    }

    void Pause() {
        Time.timeScale = 0;
        objectToDisable.SetActive(false);
        isPaused = true;
        pauseText.text = "Game is paused";
    }
    public void ResumeGame() {
        Time.timeScale = 1;
        objectToDisable.SetActive(true);
        isPaused = false;
    }
}

