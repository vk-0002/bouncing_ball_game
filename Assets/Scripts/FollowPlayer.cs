using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform Player;
    public float offset;  

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetFloat("CameraPositionY", 0);
    }
	
	// Update is called once per frame
	void Update () {


        if (Player.position.y > PlayerPrefs.GetFloat("CameraPositionY"))
        {

            PlayerPrefs.SetFloat("CameraPositionY", transform.position.y);

            transform.position = new Vector3(3.88f, Player.position.y, Player.position.z + offset);
        }
      

	}
}
