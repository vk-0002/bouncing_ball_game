using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YourScore : MonoBehaviour {

    public Text score;	
	
	// Update is called once per frame
	
     void Update()
     {
           score.text = PlayerPrefs.GetInt("Score").ToString();
     }
  
}
