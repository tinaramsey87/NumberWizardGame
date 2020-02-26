﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 5;

	public Text text;

	void Start() {
		StartGame ();
	}

	void StartGame() {
		max = 1000;
		min = 1;
		NextGuess();
	}

	public void GuessLower() {
		max = guess;
		NextGuess();
	}

	public void GuessHiger() {
		min = guess;
		NextGuess();
	}

	void NextGuess() {
		guess = Random.Range(min, max+1);
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}

}
