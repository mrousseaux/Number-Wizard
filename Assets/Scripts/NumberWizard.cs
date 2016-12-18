using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess = 500;
	// Use this for initialization
	void Start () {
		StartGame ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!!, I are smart!");
			StartGame ();
		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Higher eh?");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Lower you say?");
			print ("Higher eh?");
			max = guess;
			NextGuess();
		}
	}

	// Functions
	void StartGame () {
		max = 1001;
		min = 1;
		guess = 500;

		print ("------------------------");
		print ("");
		print ("Welcome to Number Wizard");
		print ("Pick a number but DON'T tell me");
		
		print ("The highest number you can choose is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number high or lower than " + guess + "?");
		print ("Up = higher, Down = lower, Return = equals.");
		max = max + 1
	}
	void NextGuess(){
		guess = (max + min)/2;
		print ("Higher or lower than " + guess);
	}
}
