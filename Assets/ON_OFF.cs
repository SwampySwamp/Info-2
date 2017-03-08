using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ON_OFF : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void activate()
    {
        gameObject.SetActive(true);
    }

    public void DEactivate()
    {
        gameObject.SetActive(false);
    }
}
