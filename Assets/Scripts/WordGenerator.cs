using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WordGenerator : MonoBehaviour {

	private static string[] wordList;

	static WordGenerator() {
		string path = "Assets/TxtFiles/words.txt";
		string content = File.ReadAllText(path);
		wordList = content.Split(new[] {' '}, System.StringSplitOptions.RemoveEmptyEntries);
	}

	public static string GetRandomWord () {
		int randomIndex = Random.Range(0, wordList.Length);
		string randomWord = wordList[randomIndex];
		return randomWord;
	}

}
