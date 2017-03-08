using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rookie_T65 : MonoBehaviour {

    public int PilotSkill = 2;
    public int WeaponDMG = 3;
    public int Agility = 2;
    public int Hull = 3;
    public int shields = 2;
    public int health = 5;
    public int rangeToFighter = 4;

    public bool BarrelRoll = false;
    public bool Boost = false;
    public bool Cloak = false;
    public bool Evade = false;
    public bool Focus = true;
    public bool TargetLock = true;
    public bool SLAM = false;

    public GameObject Managing;
    public GameObject button;
    public GameObject r2d2;
    public GameObject MeasureTape;

    public Manager Manage;

    public Text T65_HP;
    public Text T65_Shields;

    // Use this for initialization
    void Start () {

        Manage = Managing.GetComponent<Manager>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (health <= Hull) 
        {
            T65_Shields.text = "offline";
        }
        else
        {
            T65_Shields.text = "online";
        }

        if (transform.position.x >= 451 || transform.position.x <= -451)
        {
            health = 0;
        }

        if (transform.position.z >= 451 || transform.position.z <= -451)
        {
            health = 0;
        }

        if (health > 0)
        {
            T65_HP.text = "X-Wing HP: " + health;
        }

        if (health == 0)
        {
            Manage.T65des = true;
            T65_HP.text = "Destroyed";
            r2d2.gameObject.SetActive(true);
            MeasureTape.gameObject.SetActive(false);
            Manage.killed++;
            button.SetActive(false);
            gameObject.SetActive(false);
            Manage.IMPwin = true;
        }
	}
}
