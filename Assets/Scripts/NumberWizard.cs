using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	public Text guessText;
	public int maxGuesses = 10;
	int max;
	int min;
	int guess;
	// Use this for initialization
	void Start () {
		StartGame ();
	}
	
	// Interaction methods
	public void higherGuess(){
		min = guess;
		NextGuess();
		Debug.Log ("The number is higher");
	}
	public void lowerGuess(){
		max = guess;
		NextGuess();
		Debug.Log ("The number is lower");
	}

	// Gameplay Methods
	void StartGame () {
		max = 1001;
		min = 1;
		NextGuess ();
		
	}
	void NextGuess(){
		guess = Random.Range(min,max+1);
		guessText.text = guess.ToString ();
		maxGuesses = maxGuesses-1;
		if (maxGuesses <= 0){
			Application.LoadLevel("Win");
		}
	}
}
