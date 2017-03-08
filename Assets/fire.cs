using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {

    public bool test = false;

    public double x = 0;

    public string Name;

    private GameObject Fighter;
    public GameObject T65;
    public GameObject AcadamyTIE;
    public GameObject ObsidianTIE;
    public GameObject Managing;
    public GameObject ShootingXW;
    public GameObject ShootingTIE1;
    public GameObject ShootingTIE2;
    

    public Manager Manage;



    void Start () {

        Manage = Managing.GetComponent<Manager>();

        if (Name == "T65")
        {
            Fighter = T65;
        }

        if (Name == "TIE1")
        {
            Fighter = AcadamyTIE;
        }

        if (Name == "TIE2")
        {
            Fighter = ObsidianTIE;
        }

    }
	
	void Update () {

		if(test)
        {
            if (x == 0)
            {
                transform.Rotate(Vector3.up * -45, Space.Self);
                transform.Translate(Vector3.forward * 170, Space.Self);
                transform.localScale += new Vector3(0, 0, 300);
                
            }

            if(x < 90)
            {
                transform.Translate(Vector3.forward * -170, Space.Self);
                transform.Rotate(Vector3.up * 1, Space.Self);
                transform.Translate(Vector3.forward * 170, Space.Self);
                x++;
            }

            if (x >= 90)
            {
                transform.localScale -= new Vector3(0, 0, 300);
                transform.Translate(Vector3.forward * -170, Space.Self);
                transform.Rotate(Vector3.up * -45, Space.Self);
                x = 0;
                Manage.pilotSkill--;
                test = false;
                Manage.tested = false;
                

            }
        }
	}

    public void TestingRange()
    {
        test = true;
    } 

    void OnTriggerEnter(Collider other)
    {
        if (Fighter == AcadamyTIE || Fighter == ObsidianTIE)
        {
            if (other.CompareTag("T65"))
            {
                ShootingXW.gameObject.SetActive(true);
                Manage.inRange = true;
                Debug.Log("Object hit R3");
                Manage.select = true;
                if (other.GetComponent<Rookie_T65>().rangeToFighter > 3)
                {
                    other.GetComponent<Rookie_T65>().rangeToFighter = 3;
                }
            }
        }

        if (Fighter == T65)
        {
            if (other.CompareTag("Obsidian"))
            {
                ShootingTIE2.gameObject.SetActive(true);
                Manage.inRange = true;
                Debug.Log("Object hit R3");
                Manage.select = true;
                if (other.GetComponent<TIE2>().rangeToFighter > 3)
                {
                    other.GetComponent<TIE2>().rangeToFighter = 3;
                }
            }

            if (other.CompareTag("Acadamy"))
            {
                ShootingTIE1.gameObject.SetActive(true);
                Manage.inRange = true;
                Debug.Log("Object hit R3");
                Manage.select = true;
                if (other.GetComponent<TIE1>().rangeToFighter > 3)
                {
                    other.GetComponent<TIE1>().rangeToFighter = 3;
                }
            }
        }           
    } 
}
