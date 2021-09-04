using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text score;

    private void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
    }
    // Update is called once per frame
    void Update () {

        score.text = PlayerPrefs.GetInt("Score").ToString();
	}
}
