using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

	public Button startText;

	// Use this for initialization
	void Start () {

		startText = startText.GetComponent<Button> ();

	
	}
	
	public void StartLevel(){

		SceneManager.LoadScene (1);
}
}
