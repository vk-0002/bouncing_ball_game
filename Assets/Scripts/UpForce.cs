using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpForce : MonoBehaviour {

    public float Force = 100f;
    public Rigidbody rb;
    int Score = 0;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Step")
        {
            rb.AddForce(0, Force, 0);


            Score++;
            PlayerPrefs.SetInt("Score", Score);
        }

       
    }

    private void Updatex()
    {
        if (PlayerPrefs.GetFloat("Fall") < transform.position.y)
        {
            PlayerPrefs.SetFloat("Fall", transform.position.y);
            GetComponent<SphereCollider>().enabled = false;
        }
        if (PlayerPrefs.GetFloat("Fall") > transform.position.y)
        {
            PlayerPrefs.SetFloat("Fall", transform.position.y);
            GetComponent<SphereCollider>().enabled = true;

        }

    }
}
