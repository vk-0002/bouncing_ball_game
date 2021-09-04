using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    public Rigidbody rb;
    public Touch touch;
    private float TouchForce=2f;

    public float SideForce = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(SideForce, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-SideForce, 0, 0);
        }



        /*  if (Input.touchCount > 0)
          {
              touch = Input.GetTouch(0);

              if (touch.phase == TouchPhase.Moved)
              {

                       transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * TouchForce,
                          transform.position.y,
                          transform.position.z);
              }
          }*/

        rb.AddForce(Input.acceleration.x * 20, 0, 0);

    }
}
