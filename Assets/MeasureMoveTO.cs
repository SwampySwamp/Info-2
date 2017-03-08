using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasureMoveTO : MonoBehaviour {

    public GameObject xWing;

    void Start ()
    {

    }
	
	void Update ()
    {
        
	}

    public void TapeMoveTO()
    {
        transform.position = xWing.transform.position;
        transform.rotation = xWing.transform.rotation;
    }



}

