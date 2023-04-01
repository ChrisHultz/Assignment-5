using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {
    public InputField input;
    public Text inputText;
    public static string pass = "Player";

    public void PlayGame() {
        SceneManager.LoadScene("Main");
    }

    public void inputName() {
        pass = input.text.ToString();
        inputText.text = pass.ToUpper();
    }
}
