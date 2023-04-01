using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {

	public List<Word> words;

	public WordSpawner wordSpawner;
	public AudioSource audioSource;

	public static int WordsUsed = 0;
	private int keepTrack;

	public static int CorrectTyped = 0;
	private int keepTrack2;

	private bool hasActiveWord;
	private Word activeWord;

	public void AddWord () {
		Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
		Debug.Log(word.word);
		words.Add(word);
		keepTrack++;
		WordsUsed = keepTrack;
	}

	public void TypeLetter (char letter) {
		if (hasActiveWord) {
			if (activeWord.GetNextLetter() == letter) {
				activeWord.TypeLetter();
				keepTrack2++;
				CorrectTyped = keepTrack2;
			}
		} 
		else {
			foreach(Word word in words) {
				if (word.GetNextLetter() == letter) {
					activeWord = word;
					hasActiveWord = true;
					word.TypeLetter();
					keepTrack2++;
					CorrectTyped = keepTrack2;
					break;
				}
			}
		}
		if (hasActiveWord && activeWord.WordTyped()) {
			audioSource.Play();
			hasActiveWord = false;
			words.Remove(activeWord);
		}
	}

    public void RemoveWord(Word wordToRemove) {
        if (hasActiveWord && activeWord == wordToRemove) {
            hasActiveWord = false;
        }
        words.Remove(wordToRemove);
    }

}