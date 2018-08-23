using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemies : MonoBehaviour {

    public GameObject gc;

    private int option;

    public Text displeyItems;
    public Text option1;
    public Text option2;
    public Text option3;
    public Text option4;
    public Text option5;

	private int potionAttMod;
	private int potionDefMod;
	private int ArmMod;
	private int AttMod;
	private bool potionArrModOn = false;
	private bool potionDefModOn = false;
	private bool ArmModOn = false;
	private bool AttModOn = false;
	private int hpPotion = 1;
	private int manaPotion = 1;
	private int attUppotion;
	private int defUpPotion;
    private int totaldmg;
    
    private int ARM;
    private int HP;
    private int dmg;


    public void fight(int x)
    {
        gc.gameObject.GetComponent<MainMenu>().setEnterCombat(true);
        switch (x)
        {
            case 1: //Theif
                ARM = 10;
                HP = 7;
                dmg = 2;

                break;
            case 2:  //Billy
                ARM = 10;
                HP = 7;
                dmg = 3;
                break;
        }
        displayText(1);
    }

    public void attackHit()
    {
        int x = Random.Range(1, 21);
        if (x == 1)
        {
            displeyItems.text = "You rolled a 1 \n" +
                "CRITICAL FAIL \n " +
                "You damaged yourself \n ";
            gc.gameObject.GetComponent<playerHandeler>().hpManager(1,1);
            mobTurn();
        }
        else if (x == 20)
        {
            displeyItems.text = "You rolled a 20 \n" +
                "CRITICAL WIN \n " +
                "You do two attacks \n ";
            attackDamage(2);
        }
        else if (x >= ARM)
        {
            displeyItems.text = "You rolled a " + x +" \n" +
                "You damaged him \n ";
            attackDamage(1);
        }
        else if (x < ARM)
        {
            displeyItems.text = "You rolled a " + x + " \n" +
                "YOU MISSED \n ";
            mobTurn();
        }
    }
    
	public void skillDMG(int x){
		HP -= x;
		if (HP <= 0) { win(); } else { mobTurn(); }
	}

	public void ARMmod(int x)
	{
		ArmModOn = true;
		ArmMod = x;
	}

	public void ATTmod(int x)
	{
		AttModOn = true;
		AttMod = x;
	}

    public void attackDamage(int x) // x is how many rolls 
    {
        totaldmg = 0;

        for(int i = 0; i<x; i++)
        {
            totaldmg += Random.Range(1, gc.gameObject.GetComponent<playerHandeler>().getPlayerAttack() + 1);
        }
		displeyItems.text += "You did: " + totaldmg + potionAttMod + AttMod + " dmg";
        HP -= totaldmg + potionAttMod;

        if (HP <= 0) { win(); } else { mobTurn(); }
    }

    public void mobTurn()
    {
        totaldmg = 0;
        int x = Random.Range(1, 21);
        if (x == 1)
        {
            displeyItems.text += "He rolled a 1 \n" +
                "CRITICAL FAIL \n " +
                "He damaged himself \n";
            totaldmg = Random.Range(1, dmg+1);
            HP -= totaldmg;
        }
        else if (x == 20)
        {
            displeyItems.text += "He rolled a 20 \n" +
                "CRITICAL WIN \n " +
                "He gets to do two attacks \n";
			totaldmg = Random.Range(1, dmg + 1) + Random.Range(1, dmg + 1);

            if (totaldmg <= 0) totaldmg = 0;        

            gc.gameObject.GetComponent<playerHandeler>().hpManager(1, totaldmg);
        }
		else if (x >= gc.gameObject.GetComponent<playerHandeler>().getPlayerARM() + ArmMod)
        {
            displeyItems.text += "He rolled a " + x + " \n" +
                "He HIT YOU \n ";
            totaldmg = Random.Range(1, dmg + 1);

            if (totaldmg <= 0) totaldmg = 0;

            gc.gameObject.GetComponent<playerHandeler>().hpManager(1, totaldmg);
        }
        else if (x < gc.gameObject.GetComponent<playerHandeler>().getPlayerARM() + ArmMod)
        {
            displeyItems.text += "He rolled a " + x + " \n" +
                "HE MISSED \n ";
        }
		passTurn ();//makes sure potion effects and attack modifiers don't stay permanantely
        option = 1;
    }
	//attModifierOn
	//defModifierOn
	int tursAttmodInEffect = 0;
	int tursArmmodInEffect = 0;
	int tursPotAttInEffect = 0;
	int tursPotDefInEffect = 0;
	public void passTurn(){
		if (potionArrModOn) {
			tursPotAttInEffect += 1;
			if (tursPotAttInEffect == 2) {
				potionArrModOn = false;
				tursPotAttInEffect = 0;
				potionAttMod = 0;
			}
		}

		if (potionDefModOn) {
			tursPotDefInEffect += 1;
			if (tursPotDefInEffect == 2) {
				potionDefModOn = false;
				tursPotDefInEffect = 0;
				potionDefMod = 0;
			}
		}

		if (ArmModOn) {
			tursAttmodInEffect += 1;
			if (tursArmmodInEffect == 2) {
				ArmModOn = false;
				tursAttmodInEffect = 0;
				ArmMod = 0;
			}
		}

		if (AttModOn) {
			tursAttmodInEffect += 1;
			if (tursAttmodInEffect == 2) {
				AttModOn = false;
				tursAttmodInEffect = 0;
				AttMod = 0;
			}
		}
	}

    public void win()
    {
        gc.gameObject.GetComponent<monk>().backToStory();
        gc.gameObject.GetComponent<MainMenu>().setEnterCombat(false);
    }

    public void displayText(int x)
    {
        displeyItems.text += " \n *It's your turn*";
        if (x == 1)
        {    
            option1.text = "";
            option2.text = "Attack";
            option3.text = "Spells";
            option4.text = "Potions";
            option5.text = "";
            option = 1;
        }
        else if (x == 2)
        {
            option1.text = gc.gameObject.GetComponent<playerHandeler>().getSkill(1);
            option2.text = gc.gameObject.GetComponent<playerHandeler>().getSkill(2);
            option3.text = gc.gameObject.GetComponent<playerHandeler>().getSkill(3);
            option4.text = "Back";
            option5.text = "";
            option = 2;
        }
        else if (x == 3)
        {
            option1.text = "Hp potion";
            option2.text = "Mana Potion";
            option3.text = "Attack Up";
            option4.text = "Deff Up";
            option5.text = "Back";
            option = 3;
        }
    }

    public void options(int x)
    {
        if (option == 1) //Main menu
        {
            
            if (x == 2)
            {
                option = 0;
                attackHit(); // attack
            }
            else if (x == 3)
            {
                displayText(2); // spells
            }
            else if (x == 4)
            {
                displayText(3); // potions
            }
            
        }
        else if (option == 2) //skill
        {
            
			if (x == 1) {
				gc.gameObject.GetComponent<playerHandeler> ().doSkill (1);
			} else if (x == 2) {
				gc.gameObject.GetComponent<playerHandeler> ().doSkill (2);
			} else if (x == 3) {
				gc.gameObject.GetComponent<playerHandeler> ().doSkill (3);
			} else if (x == 4) {
				gc.gameObject.GetComponent<playerHandeler> ().doSkill (4);
			} else if (x == 5) {
                displayText(1); // back
            }
        }
        else if (option == 3) //potions
        {
            if (x == 1)
            {
				if (hpPotion > 0) {
					gc.gameObject.GetComponent<playerHandeler>().hpManager(0, 10);
					hpPotion -= 1;				
				}
            }
            else if (x == 2)
            {
				if (manaPotion > 0) {
					gc.gameObject.GetComponent<playerHandeler>().hpManager(0, 10);
					manaPotion -= 1;				
				}
            }
            else if (x == 3)
            {
				if (attUppotion > 0) {
					potionAttMod = 4;
					potionArrModOn = true;
					attUppotion -= 1;				
				}
            }
            else if (x == 4)
            {
				if (defUpPotion > 0) {
					potionDefMod = 4;
					potionDefModOn = true;
					defUpPotion -= 1;
				}
            }
            else if (x == 5)
            {
                displayText(1); // back
            }
        }
    }
}
