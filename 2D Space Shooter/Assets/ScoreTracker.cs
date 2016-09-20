using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour {

	int score = 0;
	Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text> ();
		scoreText.text = "Score: " + score;
	}
	
	public void addScore( int pointsToAdd ) {
		score += pointsToAdd;
		scoreText.text = "Score: " + score;
	}
}
