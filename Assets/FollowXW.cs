using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowXW : MonoBehaviour {

    public GameObject xWing;

    void Start()
    {
        transform.position = xWing.transform.position;
        //transform.rotation = xWing.transform.rotation;
    }

    void Update()
    {
        transform.position = xWing.transform.position;
        //transform.rotation = xWing.transform.rotation;
    }
}
