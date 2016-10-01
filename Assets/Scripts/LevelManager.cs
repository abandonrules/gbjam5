using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// temp function to see that level changing works
	void Start() {
		Debug.Log("Current level is " + Application.loadedLevel);
	}

	public void LoadLevel(string name) {
		Debug.Log("Level load requested for: " + name);
		Application.LoadLevel(name);
	}

	public void QuitRequest() {
		Debug.Log("I want to quit");
		Application.Quit();
	}

	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
