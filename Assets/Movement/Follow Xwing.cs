using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowXwing : MonoBehaviour {

    public GameObject xWing;



    void Start()
    {

    }

    void Update()
    {
        transform.position = xWing.transform.position;
        transform.rotation = xWing.transform.rotation;
    }
}

