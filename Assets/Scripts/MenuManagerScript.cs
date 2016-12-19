using UnityEngine;
using System.Collections;

public class MenuManagerScript : MonoBehaviour {
	public void menuLoad(string name){
		Debug.Log("Menu/Level Loaded: " +name);
		Application.LoadLevel (name);
	}

	public void quitReturn(){
		Debug.Log("Game Quit.");
		Application.Quit ();
	}
}
