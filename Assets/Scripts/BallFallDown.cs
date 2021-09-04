using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFallDown : MonoBehaviour {

    public GameObject gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Over")
        {
            GameObject.Find("GameManager").GetComponent<GameOver>().EndGame();

        }
    }
}
