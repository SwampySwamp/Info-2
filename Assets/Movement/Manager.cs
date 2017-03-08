using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public bool target = false;
    public bool inRange = false;
    public bool IMPwin = false;
    public bool REBwin = false;
    public bool combatEND = false;
    public bool tested = false;
    public bool select = false;
    public bool TIE1des = false;
    public bool TIE2des = false;
    public bool T65des = false;
    public bool toDO = true;

    public int totalNumberShips = 3;
    public int phase = 0;
    public int pilotSkill = 15;
    public int reversePS = 0;
    public int killed = 0;
    public int chosen = 0;
    public int moved = 0;
    public int range = 4;
    private int xyz = 0;

    private int[] a = new int[20];
    private int[] d = new int[20];

    public GameObject planningCanvas;
    public GameObject CombatCanvas;
    public GameObject T65;
    public GameObject AcadamyTIE;
    public GameObject ObsidianTIE;
    public GameObject MeasureT65;
    public GameObject MeasureAcadamyTIE;
    public GameObject MeasureObsidianTIE;
    public GameObject MeasureT65_R2;
    public GameObject MeasureAcadamyTIE_R2;
    public GameObject MeasureObsidianTIE_R2;
    public GameObject MeasureT65_R1;
    public GameObject MeasureAcadamyTIE_R1;
    public GameObject MeasureObsidianTIE_R1;
    public GameObject blaster;
    public GameObject astromech;
    public GameObject QuitButton;
    private GameObject Fighter;
    private GameObject Victim;

    public TIE1 TIE1script;
    public TIE2 TIE2script;
    public Rookie_T65 Rookie_T65script;
    public fire forTestingR3;
    public fireR2 forTestingR2;
    public fireR1 forTestingR1;
    public Movement TIE1Move;
    public Movement TIE2Move;
    public Movement T65Move;

    public Transform ENDcombat;
    public Transform ReadyButton;

    public Text winTEXT;





    
    void Start () {

        planningCanvas.gameObject.SetActive(false);

        CombatCanvas.SetActive(false);


        MeasureT65.GetComponent<MeasureMoveTO>().TapeMoveTO();
        MeasureAcadamyTIE.GetComponent<MeasureMoveTO>().TapeMoveTO();
        MeasureObsidianTIE.GetComponent<MeasureMoveTO>().TapeMoveTO();
        MeasureT65_R2.GetComponent<MeasureMoveTO>().TapeMoveTO();
        MeasureAcadamyTIE_R2.GetComponent<MeasureMoveTO>().TapeMoveTO();
        MeasureObsidianTIE_R2.GetComponent<MeasureMoveTO>().TapeMoveTO();
        MeasureT65_R1.GetComponent<MeasureMoveTO>().TapeMoveTO();
        MeasureAcadamyTIE_R1.GetComponent<MeasureMoveTO>().TapeMoveTO();
        MeasureObsidianTIE_R1.GetComponent<MeasureMoveTO>().TapeMoveTO();

        TIE1script = AcadamyTIE.GetComponent<TIE1>();
        TIE2script = ObsidianTIE.GetComponent<TIE2>();
        Rookie_T65script = T65.GetComponent<Rookie_T65>();
        TIE1Move = AcadamyTIE.GetComponent<Movement>();
        TIE2Move = ObsidianTIE.GetComponent<Movement>();
        T65Move = T65.GetComponent<Movement>();

        
    }

    
    void Update () {

        winTEST();

        if (phase == 0)
        {
            phaseONE();
            planningCanvas.gameObject.SetActive(true);
            toDO = true;
        }

        if (phase == 1)
        {
            ReadyButton.GetComponent<Button>().interactable = false;
            planning();
            moved = 0;
            if (chosen >= totalNumberShips - killed)
            {
                ReadyButton.GetComponent<Button>().interactable = true;
            }


        }

        if (phase == 2)
        {
            planningCanvas.gameObject.SetActive(false);
            actions();
            ENDcombat.GetComponent<Button>().interactable = false;
            MeasureT65.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureAcadamyTIE.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureObsidianTIE.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureT65_R2.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureAcadamyTIE_R2.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureObsidianTIE_R2.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureT65_R1.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureAcadamyTIE_R1.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureObsidianTIE_R1.GetComponent<MeasureMoveTO>().TapeMoveTO();
        }

        if (phase == 3)
        {
            if(toDO && moved >= totalNumberShips - killed)
            {
                MeasureT65.GetComponent<MeasureMoveTO>().TapeMoveTO();
                MeasureAcadamyTIE.GetComponent<MeasureMoveTO>().TapeMoveTO();
                MeasureObsidianTIE.GetComponent<MeasureMoveTO>().TapeMoveTO();
                MeasureT65_R2.GetComponent<MeasureMoveTO>().TapeMoveTO();
                MeasureAcadamyTIE_R2.GetComponent<MeasureMoveTO>().TapeMoveTO();
                MeasureObsidianTIE_R2.GetComponent<MeasureMoveTO>().TapeMoveTO();
                MeasureT65_R1.GetComponent<MeasureMoveTO>().TapeMoveTO();
                MeasureAcadamyTIE_R1.GetComponent<MeasureMoveTO>().TapeMoveTO();
                MeasureObsidianTIE_R1.GetComponent<MeasureMoveTO>().TapeMoveTO();
                toDO = false;
            }

            if (!toDO)
            {
                CombatCanvas.gameObject.SetActive(true);
                firePhase();
            }

            
        }

        if (phase == 4)
        {
            CombatCanvas.gameObject.SetActive(false);
            T65Move.picked = false;
            TIE1Move.picked = false;
            TIE2Move.picked = false;
            MeasureT65.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureAcadamyTIE.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureObsidianTIE.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureT65_R2.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureAcadamyTIE_R2.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureObsidianTIE_R2.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureT65_R1.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureAcadamyTIE_R1.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureObsidianTIE_R1.GetComponent<MeasureMoveTO>().TapeMoveTO();
            phase = 0;

        }

        if (phase == 90)
        {
            QuitButton.gameObject.SetActive(true);
            winTEXT.text = "IMPERIUM WINS!";
            winTEXT.gameObject.SetActive(true);
        }

        if(phase == 100)
        {
            QuitButton.gameObject.SetActive(true);
            winTEXT.text = "REBELS WINS!";
            winTEXT.gameObject.SetActive(true);
        }
        

    }

    public void phaseONE ()
    {
        phase++;

    }

    public void planning ()
    {

    }

    public void actions ()
    {
        reversePStest();
    }

    public void firePhase ()
    {

        Combat();

    }

    public void ready()
    {
        astromech.gameObject.SetActive(false);

        if (chosen >= totalNumberShips - killed)
        {
            astromech.gameObject.SetActive(true);
            phase++;
            planningCanvas.gameObject.SetActive(false);
        }
    }

    public void reversePStest()
    {
        if (reversePS <= pilotSkill)
        {
            if (!T65des)
            {
                if (Rookie_T65script.PilotSkill == reversePS)
                {
                    T65Move.active = true;
                    chosen--;
                }
            }


            if (!TIE1des)
            {
                if (TIE1script.PilotSkill == reversePS)
                {
                    TIE1Move.active = true;
                    chosen--;
                }
            }


            if (!TIE2des)
            {
                if (TIE2script.PilotSkill == reversePS)
                {
                    TIE2Move.active = true;
                    chosen--;
                }
            }


            MeasureT65.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureAcadamyTIE.GetComponent<MeasureMoveTO>().TapeMoveTO();
            MeasureObsidianTIE.GetComponent<MeasureMoveTO>().TapeMoveTO();

            reversePS++;
        }

        if (reversePS >= pilotSkill)
        {
            reversePS = 0;
            phase++;
        }
    }

    public void Combat()
    {

        if (pilotSkill >= 0 && !combatEND && !select)
        {
            if(!T65des) 
            {
                forTestingR3 = MeasureT65.GetComponent<fire>();
                forTestingR2 = MeasureT65_R2.GetComponent<fireR2>();
                forTestingR1 = MeasureT65_R1.GetComponent<fireR1>();
                if (Rookie_T65script.PilotSkill == pilotSkill && !tested)
                {
                    Fighter = T65;
                    forTestingR3.TestingRange();
                    forTestingR2.TestingRange();
                    forTestingR1.TestingRange();
                    tested = true;
                }
            }

            if (!TIE1des)
            {
                forTestingR3 = MeasureAcadamyTIE.GetComponent<fire>();
                forTestingR2 = MeasureAcadamyTIE_R2.GetComponent<fireR2>();
                forTestingR1 = MeasureAcadamyTIE_R1.GetComponent<fireR1>();
                if (TIE1script.PilotSkill == pilotSkill && !tested)
                {
                    Fighter = AcadamyTIE;
                    forTestingR3.TestingRange();
                    forTestingR2.TestingRange();
                    forTestingR1.TestingRange();
                    tested = true;
                }
            }

            if (!TIE2des)
            {
                forTestingR3 = MeasureObsidianTIE.GetComponent<fire>();
                forTestingR2 = MeasureObsidianTIE_R2.GetComponent<fireR2>();
                forTestingR1 = MeasureObsidianTIE_R1.GetComponent<fireR1>();
                if (TIE2script.PilotSkill == pilotSkill && !tested)
                {
                    Fighter = ObsidianTIE;
                    forTestingR3.TestingRange();
                    forTestingR2.TestingRange();
                    forTestingR1.TestingRange();
                    tested = true;
                }
            }


            if (!tested)
            {
                 pilotSkill--;               
            }
        }

        if (inRange && target)
        {
            calculation();
            select = false;
            inRange = false;
            target = false;
        }



        if (pilotSkill <= 0)
        {
            ENDcombat.GetComponent<Button>().interactable = true;
            pilotSkill = 15;
            combatEND = true;
        }
    }

    public void VictimTIE1()
    {
        Victim = AcadamyTIE;
        target = true;
    }

    public void VictimTIE2()
    {
        Victim = ObsidianTIE;
        target = true;
    }

    public void VictimT65()
    {
        Victim = T65;
        target = true;
    }

    public void calculation()
    {
        blaster.gameObject.SetActive(false);
        blaster.gameObject.SetActive(true);

        while (xyz < 20)
        {
            a[xyz] = 0;
            d[xyz] = 0;
            xyz++;
        }

        xyz = 0;

        int length = 0;

        if (Victim == AcadamyTIE)
        {
            range = TIE1script.rangeToFighter;
        }

        if (Victim == ObsidianTIE)
        {
            range = TIE2script.rangeToFighter;
        }

        if (Victim == T65)
        {
            range = Rookie_T65script.rangeToFighter;
        }
        if (Fighter == AcadamyTIE)
        {
            length = TIE1script.WeaponDMG;            
        }

        if (Fighter == ObsidianTIE)
        {
            length = TIE2script.WeaponDMG;
        }

        if (Fighter == T65)
        {
            length = Rookie_T65script.WeaponDMG;
        }

         if(range == 1)
         {
             length++;
         } 


        xyz = 0;

        while(xyz < length)
        {
            a[xyz] = Random.Range(1, 8);
            xyz++;
        }

        if (Victim == AcadamyTIE)
        {
            length = TIE1script.Agility;
        }

        if (Victim == ObsidianTIE)
        {
            length = TIE2script.Agility;
        }

        if (Victim == T65)
        {
            length = Rookie_T65script.Agility;
        }

        if (range == 3)
        {
            length++;
        }


        xyz = 0;

        while (xyz < length)
        {
            d[xyz] = Random.Range(1, 8);
            xyz++;
        }

        xyz = 0;

        int DMG = 0;

        while(xyz < a.Length)
        {
            if(a[xyz] == 5 || a[xyz] == 6 || a[xyz] == 7)
            {
                DMG++;
            }

            if (a[xyz] == 8)
            {
                DMG++;

                if (Victim == T65 && Rookie_T65script.health <= Rookie_T65script.Hull)
                {
                    DMG++;
                }

                if (Victim == AcadamyTIE && TIE1script.health <= TIE1script.Hull)
                {
                    DMG++;
                }

                if (Victim == ObsidianTIE && TIE2script.health <= TIE2script.Hull)
                {
                    DMG++;
                }


            }

            xyz++;
        }
        Debug.Log("hits:" + DMG);
        xyz = 0;

        while (xyz < d.Length)
        {
            if (a[xyz] == 8 || a[xyz] == 6 || a[xyz] == 7)
            {
                DMG--;
            }

            xyz++;
        }
        Debug.Log("Schaden:" + DMG);

        if (Victim == AcadamyTIE && DMG > 0)
        {
            TIE1script.health = TIE1script.health - DMG;

            Debug.Log("TIE1 Health left:" + TIE1script.health);
        }

        if (Victim == ObsidianTIE && DMG > 0)
        {
            TIE2script.health = TIE2script.health - DMG;
            Debug.Log("TIE2 Health left:" + TIE2script.health);
        }

        if (Victim == T65 && DMG > 0)
        {
            Rookie_T65script.health = Rookie_T65script.health - DMG;
            Debug.Log("T65 Health left:" + Rookie_T65script.health);
        }
        target = false;
        winTEST();
        range = 4;
    }

    public void endCombat()
    {
        if (combatEND)
        {
            phase++;
            combatEND = false;
        }
    }

    public void winTEST()
    {
        if (killed == 2 && Rookie_T65script.health > 0)
        {
            REBwin = true;
        }

        if (IMPwin)
        {
            phase = 90;
        }

        if(REBwin)
        {
            phase = 100;
        }
    }

}
