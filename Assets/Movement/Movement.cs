using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

    bool ONEs = false;
    bool TWOs = false;
    bool THREEs = false;
    bool FOURs = false;
    bool FIVEs = false;
    bool ONEbR = false;
    bool TWObR = false;
    bool THREEbR = false;
    bool ONEtR = false;
    bool TWOtR = false;
    bool THREEtR = false;
    bool ONEbL = false;
    bool TWObL = false;
    bool THREEbL = false;
    bool ONEtL = false;
    bool TWOtL = false;
    bool THREEtL = false;
    bool FOURkt = false;
    bool FIVEkt = false;
    bool THREEkt = false;
    bool stress = false;

    public bool picked = false;

    public GameObject ManagerChosen;
    public Manager Manage;

    public Text stressed;

    public bool active = false;

    int count = 0;
    float distanceONEb = 2 * 80 * Mathf.PI / 8 / 45;
    float distanceTWOb = 2 * 130 * Mathf.PI / 8 / 45;
    float distanceTHREEb = 2 * 180 * Mathf.PI / 8 / 45;
    float distanceONEt = 2 * 35 * Mathf.PI / 4 / 45;
    float distanceTWOt = 125 * Mathf.PI / 4 / 45;
    float distanceTHREEt = 2 * 90 * Mathf.PI / 4 / 45;

    void Start()
    {
        Manage = ManagerChosen.GetComponent<Manager>();

    }

    void FixedUpdate()
    {
        if(stress)
        {
            stressed.text = "!";
        }

        if(!stress)
        {
            stressed.text = "";
        }

        if (active)
        {
            if (ONEs)
            {

                transform.Translate(Vector3.forward * 4, Space.Self);

                if (count < 8)
                {
                    transform.Translate(Vector3.forward * 5, Space.Self);
                    count++;
                }

                if (count == 8)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    ONEs = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }

            if (TWOs)
            {

                transform.Translate(Vector3.forward * 4, Space.Self);

                if (count < 16)
                {
                    transform.Translate(Vector3.forward * 5, Space.Self);
                     count++;
                }

                if (count == 16)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    TWOs = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }

            if (THREEs)
            {
                    transform.Translate(Vector3.forward * 4, Space.Self);

                if(count < 24)
                {
                    transform.Translate(Vector3.forward * 5, Space.Self);
                    count++;
                }
                if (count == 24)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    THREEs = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }

            if (FOURs)
            {

                transform.Translate(Vector3.forward * 4, Space.Self);

                if (count < 32)
                {
                    transform.Translate(Vector3.forward * 5, Space.Self);
                    count++;
                }
                if (count == 32)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    FOURs = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }

            if (FIVEs)
            {

                transform.Translate(Vector3.forward * 4, Space.Self);

                if (count < 40)
                {
                    transform.Translate(Vector3.forward * 5, Space.Self);
                    count++;
                }
                if (count == 40)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    FIVEs = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }

            if (FOURkt)
            {

                transform.Translate(Vector3.forward * 4, Space.Self);

                if (count < 32)
                {
                    transform.Translate(Vector3.forward * 5, Space.Self);
                    count++;
                }
                if (count == 32)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    transform.Rotate(Vector3.up * 180);
                    FOURkt = false;
                    count = 0;
                    active = false;
                    stress = true;
                    Manage.moved++;
                }
            }

            if (FIVEkt)
            {

                transform.Translate(Vector3.forward * 4, Space.Self);

                if (count < 40)
                {
                    transform.Translate(Vector3.forward * 5, Space.Self);
                    count++;
                }
                if (count == 40)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    transform.Rotate(Vector3.up * 180);
                    FIVEkt = false;
                    count = 0;
                    active = false;
                    stress = true;
                    Manage.moved++;
                }       
            }

            if (THREEkt)
            {

                transform.Translate(Vector3.forward * 4, Space.Self);

                if (count < 24)
                {
                    transform.Translate(Vector3.forward * 5, Space.Self);
                    count++;
                }
                if (count == 24)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    transform.Rotate(Vector3.up * 180);
                    THREEkt = false;
                    count = 0;
                    active = false;
                    stress = true;
                    Manage.moved++;
                }
            }

            if (ONEbR)
            {
                transform.Translate(Vector3.forward * 4, Space.Self);
                if (count < 45)
                {
                    transform.Rotate(Vector3.up * 1);
                    transform.Translate(Vector3.forward * distanceONEb, Space.Self);
                    count++;
                }
                if (count == 45)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    ONEbR = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }

            if (TWObR)
            {
                transform.Translate(Vector3.forward * 4, Space.Self);
                if (count < 45)
                {
                    transform.Rotate(Vector3.up * 1);
                    transform.Translate(Vector3.forward * distanceTWOb, Space.Self);
                    count++;
                }
                if (count == 45)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    TWObR = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }


            if (THREEbR)
            {
                transform.Translate(Vector3.forward * 4, Space.Self);
                if (count < 45)
                {
                    transform.Rotate(Vector3.up * 1);
                    transform.Translate(Vector3.forward * distanceTHREEb, Space.Self);
                    count++;
                }
                if (count == 45)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    THREEbR = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }

            if (ONEtR)
            {
                transform.Translate(Vector3.forward * 4, Space.Self);
                if (count < 45)
                {
                    transform.Rotate(Vector3.up * 2);
                    transform.Translate(Vector3.forward * distanceONEt, Space.Self);
                    count++;
                }
                if (count == 45)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    ONEtR = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }

            if (TWOtR)
            {
                transform.Translate(Vector3.forward * 4, Space.Self);
                if (count < 45)
                {
                    transform.Rotate(Vector3.up * 2);
                    transform.Translate(Vector3.forward * distanceTWOt, Space.Self);
                    count++;
                }
                if (count == 45)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    TWOtR = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }

            if (THREEtR)
            {
                transform.Translate(Vector3.forward * 4, Space.Self);
                if (count < 45)
                {
                    transform.Rotate(Vector3.up * 2);
                    transform.Translate(Vector3.forward * distanceTHREEt, Space.Self);
                    count++;
                }
                if (count == 45)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    THREEtR = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }

            if (ONEbL)
            {
                transform.Translate(Vector3.forward * 4, Space.Self);
                if (count < 45)
                {
                    transform.Rotate(Vector3.up * -1);
                    transform.Translate(Vector3.forward * distanceONEb, Space.Self);
                    count++;
                }
                if (count == 45)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    ONEbL = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }

            if (TWObL)
            {
                transform.Translate(Vector3.forward * 4, Space.Self);
                if (count < 45)
                {
                    transform.Rotate(Vector3.up * -1);
                    transform.Translate(Vector3.forward * distanceTWOb, Space.Self);
                    count++;
                }
                if (count == 45)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    TWObL = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }

            if (THREEbL)
            {
                transform.Translate(Vector3.forward * 4, Space.Self);
                if (count < 45)
                {
                    transform.Rotate(Vector3.up * -1);
                    transform.Translate(Vector3.forward * distanceTHREEb, Space.Self);
                    count++;
                }

                if (count == 45)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    THREEbL = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }

            if (ONEtL)
            {
                transform.Translate(Vector3.forward * 4, Space.Self);
                if (count < 45)
                {
                    transform.Rotate(Vector3.up * -2);
                    transform.Translate(Vector3.forward * distanceONEt, Space.Self);
                    count++;
                }
                if (count == 45)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    ONEtL = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }

            if (TWOtL)
            {
                transform.Translate(Vector3.forward * 4, Space.Self);
                if (count < 45)
                {
                    transform.Rotate(Vector3.up * -2);
                    transform.Translate(Vector3.forward * distanceTWOt, Space.Self);
                    count++;
                }
                if (count == 45)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    TWOtL = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }

            if (THREEtL)
            {
                transform.Translate(Vector3.forward * 4, Space.Self);
                if (count < 45)
                {
                    transform.Rotate(Vector3.up * -2);
                    transform.Translate(Vector3.forward * distanceTHREEt, Space.Self);
                    count++;
                }
                if (count == 45)
                {
                    transform.Translate(Vector3.forward * 4, Space.Self);
                    THREEtL = false;
                    count = 0;
                    active = false;
                    Manage.moved++;
                }
            }
        }
    }

    public void ONEstraight()
    {
        caped();
        MoveReset();
        ONEs = true;
        Manage.chosen++;
        picked = true;
    }

    public void TWOstraight()
    {
        caped();
        MoveReset();
        TWOs = true;
        Manage.chosen++;
        picked = true;
    }

    public void THREEstraight()
    {
        caped();
        MoveReset();
        THREEs = true;
        Manage.chosen++;
        picked = true;
    }

    public void FOURstraight()
    {
        caped();
        MoveReset();
        FOURs = true;
        Manage.chosen++;
        picked = true;
    }

    public void FIVEstraight()
    {
        caped();
        MoveReset();
        FIVEs = true;
        Manage.chosen++;
        picked = true;
    }

    public void ONEbankR()
    {
        caped();
        MoveReset();
        ONEbR = true;
        Manage.chosen++;
        picked = true;
    }

    public void TWObankR()
    {
        caped();
        MoveReset();
        TWObR = true;
        Manage.chosen++;
        picked = true;
    }

    public void THREEbankR()
    {
        caped();
        MoveReset();
        THREEbR = true;
        Manage.chosen++;
        picked = true;
    }

    public void ONEturnR()
    {
        caped();
        MoveReset();
        ONEtR = true;
        Manage.chosen++;
        picked = true;
    }

    public void TWOturnR()
    {
        caped();
        MoveReset();
        TWOtR = true;
        Manage.chosen++;
        picked = true;
    }

    public void THREEturnR()
    {
        caped();
        MoveReset();
        THREEtR = true;
        Manage.chosen++;
        picked = true;
    }

    public void ONEbankL()
    {
        caped();
        MoveReset();
        ONEbL = true;
        Manage.chosen++;
        picked = true;
    }

    public void TWObankL()
    {
        caped();
        MoveReset();
        TWObL = true;
        Manage.chosen++;
        picked = true;
    }

    public void THREEbankL()
    {
        caped();
        MoveReset();
        THREEbL = true;
        Manage.chosen++;
        picked = true;
    }

    public void ONEturnL()
    {
        caped();
        MoveReset();
        ONEtL = true;
        Manage.chosen++;
        picked = true;
    }

    public void TWOturnL()
    {
        caped();
        MoveReset();
        TWOtL = true;
        Manage.chosen++;
        picked = true;
    }

    public void THREEturnL()
    {
        caped();
        MoveReset();
        THREEtL = true;
        Manage.chosen++;
        picked = true;
    }

    public void FOURkTurn()
    {
        caped();
        MoveReset();
        FOURkt = true;
        Manage.chosen++;
        picked = true;

        if (stress)
        {
            MoveReset();
            TWOs = true;
        }
    }

    public void FIVEkTurn()
    {
        caped();
        MoveReset();
        FIVEkt = true;
        Manage.chosen++;
        picked = true;

        if (stress)
        {
            MoveReset();
            TWOs = true;
        }
    }

    public void THREEkTurn()
    {
        caped();
        MoveReset();
        THREEkt = true;
        Manage.chosen++;
        picked = true;

        if(stress)
        {
            MoveReset();
            TWOs = true;
        }

    }

    public void ONEsGreen()
    {
        ONEstraight();
        stress = false;
    }

    public void TWOsGreen()
    {
        TWOstraight();
        stress = false;
    }

    public void THREEsGreen()
    {
        THREEstraight();
        stress = false;
    }

    public void ONEbankLGreen()
    {
        ONEbankL();
        stress = false;
    }

    public void ONEbankRGreen()
    {
        ONEbankR();
        stress = false;
    }

    public void TWObankRGreen()
    {
        TWObankR();
        stress = false;
    }

    public void TWObankLGreen()
    {
        TWObankL();
        stress = false;
    }

    public void MoveReset()
    {
        ONEs = false;
        TWOs = false;
        THREEs = false;
        FOURs = false;
        FIVEs = false;
        ONEbR = false;
        TWObR = false;
        THREEbR = false;
        ONEtR = false;
        TWOtR = false;
        THREEtR = false;
        ONEbL = false;
        TWObL = false;
        THREEbL = false;
        ONEtL = false;
        TWOtL = false;
        THREEtL = false;
        FOURkt = false;
        FIVEkt = false;
        THREEkt = false;
    }

    public void caped()
    {
        if(picked)
        {
            Manage.chosen--;
        }
    }
}
