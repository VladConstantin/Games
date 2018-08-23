using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameController : MonoBehaviour {

    public GameObject menu;

    public Text Armour;
    public Text INIT;
    public Text STR;
    public Text DEX;
    public Text INT;
    public Text WIZ;
    public Text CHA;

    public Text Skill1;
    public Text Skill2;
    public Text Skill3;
    public Text Skill4;

    public void setAttribute()
    {
        STR.text = "11";
        DEX.text = "16";
        INT.text = "10";
        WIZ.text = "10";
        CHA.text = "12";
    }

    public void prepareGame(int x)
    {
        menu.gameObject.GetComponent<playerHandeler>().getCharStats(x);
        switch (x)
        {
            case 1:
                //warrior
                Armour.text = "13"; 
                INIT.text = "+1";
                STR.text = "16";
                DEX.text = "10";
                INT.text = "9";
                WIZ.text = "9";
                CHA.text = "15";

                Skill1.text = "Primal Rage";
                Skill2.text = "Head Butt";
                Skill3.text = "High Shield";
                Skill4.text = "IronHide";
                
                break;
            case 2:
                //mage
                Armour.text = "";
                INIT.text = "";
                STR.text = "";
                DEX.text = "";
                INT.text = "";
                WIZ.text = "";
                CHA.text = "";

                Skill1.text = "";
                Skill2.text = "";
                Skill3.text = "";
                Skill4.text = "";
                
                break;
            case 3:
                //rogue
                Armour.text = "";
                INIT.text = "";
                STR.text = "";
                DEX.text = "";
                INT.text = "";
                WIZ.text = "";
                CHA.text = "";

                Skill1.text = "";
                Skill2.text = "";
                Skill3.text = "";
                Skill4.text = "";
                
                break;
            case 4:
                //monk
                Armour.text = "13";
                INIT.text = "Initiative: 10";
                STR.text = "10";
                DEX.text = "15";
                INT.text = "9";
                WIZ.text = "10";
                CHA.text = "10";

                Skill1.text = "Drunken Style";
                Skill2.text = "Body Knowledge";
                Skill3.text = "Quivering Palm";
                Skill4.text = "Tranquility";
                
                menu.gameObject.GetComponent<monk>().monkExpo(1);
                break;
        }
    }
}
