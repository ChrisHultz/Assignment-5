using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour {

	public WordManager wordManager;
	public Camera myCam;
	public static int CountTyped = 0;
	private int keepTrack;

	// Update is called once per frame
	void Update () {
		foreach (char letter in Input.inputString) {
			wordManager.TypeLetter(letter);
			myCam.GetComponent<AudioSource>().Play();
			keepTrack++;
			CountTyped = keepTrack;
		}
	}
}
