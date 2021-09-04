using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighScore : MonoBehaviour {

    public Text score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (PlayerPrefs.GetInt("HighScore") < PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score"));
        }
        score.text = PlayerPrefs.GetInt("HighScore").ToString();

    }
}
