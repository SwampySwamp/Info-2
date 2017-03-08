using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TIE1 : MonoBehaviour {

    public int PilotSkill = 1;
    public int WeaponDMG = 2;
    public int Agility = 3;
    public int Hull = 3;
    public int shields = 0;
    public int health = 3;
    public int rangeToFighter = 4;

    public bool BarrelRoll = true;
    public bool Boost = false;
    public bool Cloak = false;
    public bool Evade = true;
    public bool Focus = true;
    public bool TargetLock = false;
    public bool SLAM = false;

    public GameObject Managing;
    public GameObject button;
    public GameObject crash;
    public GameObject MeasureTape;

    public Manager Manage;

    public Text TIE1_HP;

    // Use this for initialization
    void Start()
    {

        Manage = Managing.GetComponent<Manager>();

    }

    // Update is called once per frame
    void Update()
    {
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
            TIE1_HP.text = "TIE1 HP: " + health;
        }

        if (health == 0)
        {
            Manage.TIE1des = true;
            TIE1_HP.text = "Destroyed";
            crash.gameObject.SetActive(true);
            MeasureTape.gameObject.SetActive(false);
            Manage.killed++;
            button.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
