using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeStaps : MonoBehaviour {

    public GameObject Step;
    public GameObject RedStep;
    float Distance = 6;
    int rand;
	// Use this for initialization
	void Start () {
        int i;
        for(i=0;i<170;i++)
        {
            rand = Random.Range(0, 5);

            if(rand==0)
            {
                makeRedStep();
            }
            makeStep();
        }
	}
	
    void makeStep()
    {
        GameObject tempStep = Instantiate(Step);
        tempStep.transform.position = new Vector3(Random.Range(1,7), Distance, -3);
        Distance += 6;
        
    }

    void makeRedStep()
    {
        GameObject tempStep = Instantiate(RedStep);
        tempStep.transform.position = new Vector3(Random.Range(1, 7), Distance, -3);
        Distance += 3;

    }

}
