using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHandeler : MonoBehaviour {

    public GameObject go;
    public GameObject deathScreen;

    public Slider Infamy;
    public Slider hp;
    public Slider mana;

    public Text sk1lvl;
    public Text sk2lvl;
    public Text sk3lvl;
    public Text sk4lvl;
    public Text goldAmmount;

    public int xp = 0;
    public int skillPoint;
    public int gold;
    private int character;

    private int abilityPoint;

    public int maxHealth;
    public int currentHealth;
    public int maxMana;
    public int currentMana;
    public float infamy;

    private int ARM;
    private int STR;
    private int INIT;
    private int DEX;
    private int INT;
    private int WIZ;
    private int CHA;

    public int helmLvl = 1;
    public int chestLvl = 1;
    public int legsLvl = 1;
    public int bootsLvl = 1;
    public int weaponlvl = 1;

    private string skill1;
    private string skill2;
    private string skill3;
    private string skill4;

    private int sk1 = 0;
    private int sk2 = 0;
    private int sk3 = 0;
    private int sk4 = 0;

	private int turnTracker;

    private int charType;

    public void skillLvlUp(int x)
    {
        if(skillPoint > 0)
        {
            switch (x)
            {
                case 1: // skill 1
                    sk1 += 1;
                    sk1lvl.text = "LVL: " + sk1;
                    skillPoint -= 1;
                        break;
                case 2: // skill 2
                    sk2 += 1;
                    sk2lvl.text = "LVL: " + sk2;
                    skillPoint -= 1;
                     break;
                case 3: // skill 3
                    sk3 += 1;
                    sk3lvl.text = "LVL: " + sk3;
                    skillPoint -= 1;
                        break;
                case 4: // skill 4
                    sk4 += 1;
                    sk4lvl.text = "LVL: " + sk4;
                    skillPoint -= 1;
                     break;
            }
        }
    }

    public void setSkillPoint(int x){
        skillPoint = x;
    }

    public void equipmentlvlUp(int x, int price)
    {
        if (gold >= price)
        {
            switch(x)
            {
                case 1: // skill 1
                    helmLvl += 1;
                   // helmLvl.text = "LVL: " + helmLvl;
                     break;
                case 2: // skill 2
                    chestLvl += 1;
                    //chestLvl.text = "LVL: " + chestLvl;
                     break;
                case 3: // skill 3
                    legsLvl += 1;
                    //legsLvl.text = "LVL: " + legsLvl;
                break;
                case 4: // skill 4
                    bootsLvl += 1;
                    //bootsLvl.text = "LVL: " + bootsLvl;
                     break;
                case 5: // skill 4
                    weaponlvl += 1;
                    //weaponlvl.text = "LVL: " + weaponlvl;
                    break;
            }
        }
    }

    public void lvlUp()
    {
        ARM = 13;
        STR = 11;
        DEX = 16;
        INT = 10;
        WIZ = 10;
        CHA = 12;
    }

    public void setGold(int x, int y, int z)
    {
        goldAmmount.text = "Gold: " + x + "\n" +
            "HP Potion: " + y + "\n" +
            "Mana Potion: " + z;
    }

    public void getCharStats(int x)
    {
        character = x;
        switch (x)
        {
            case 1: //warrior
                
                break;
            case 2:
                break;
            case 3:
                break;
		case 4:
			maxHealth = 12;
			hp.maxValue = maxHealth;
			hp.value = maxHealth;
			currentHealth = maxHealth;
			maxMana = 10;
			mana.maxValue = maxMana;
			mana.value = maxMana;
			currentMana = maxMana;
            ARM = 13;
            STR = 10;
            DEX = 15;
            INT = 9;
            WIZ = 10;
            CHA = 10;
            INIT = 1;
            skill1 = "Drunken Style";
            skill2 = "Body Knowledge";
            skill3 = "Quivering Palm";
            skill4 = "Tranquility";
                break;
        }
    }

	public void doSkill(int x){
	
		switch(character)
		{
		case 1:
			break;
		case 2:
			break;
		case 3:
			break;
		case 4:
			if (x == 1) {//drunken style
				if(currentMana >= 4 && sk1 != 0){
					go.gameObject.GetComponent<enemies> (). ARMmod(sk1);
					manaManager(1,4);
				}
			} else if (x == 2) {//body knowledge
				if(currentMana >= 4 && sk2 != 0){
					go.gameObject.GetComponent<enemies> (). ATTmod(sk2);
					manaManager(1,4);
				}
			} else if (x == 3) {//quivering palm
				if(currentMana >= 4 && sk3 != 0){
					go.gameObject.GetComponent<enemies> ().skillDMG (sk3 * 3);
					manaManager(1,4);
				}
			} else { //tranquility is passive
			//passive skill
			}
			break;
		}
	}

    public string getSkill(int x)
    {
        if (x == 1)
        {
        return skill1;

        }
        else if (x == 2)
        {
            return skill2;

        }
        else if (x == 3)
        {
            return skill3;

        }
        else if (x == 4)
        {
            return skill4;

        }
        return "Not Found";
    }

    public int getPlayerAttack()
    {
		switch(character){
		case 1: //warrior attack modifirer is STR
			return ((STR/3) + (weaponlvl*2));
			break;
		case 2: //mage attack modifier is INT
			return ((INT/3) + (weaponlvl*2));
			break;
		case 3: //rogue attack modifier is DEX
			return ((DEX/3) + (weaponlvl*2));
			break;
		case 4: //monk attack modifer is DEX
			return ((DEX/3) + (weaponlvl*2));
			break;
		}
        return 6;
    }

    public int getPlayerARM()
    {
		return ARM;
    }

    public void hpManager(int x, int y) // x is heal/damage AND y is by how much
    {
        if (x == 0) // HEAL
        {
			currentHealth += y;
            if(currentHealth >= maxHealth)
            {
                currentHealth = maxHealth;
				hp.value = currentHealth;
            }
            else
            {               
                hp.value = currentHealth;
            }

        } else // DAMAGE
        {
			currentHealth -= y;
            if(currentHealth <= 0)
            {
                deathScreen.gameObject.SetActive(true);
            }
            else
            {        
                hp.value = currentHealth;
            }
        }
    }

    public void manaManager(int x, int y) // x is Restore/Drain AND y is by how much
    {
        if (x == 0) // Restore
        {
			currentMana += y;
            if (currentMana >= maxMana)
            {
                currentMana = maxMana;
				mana.value = currentMana;
            }
            else
            {              
                mana.value = currentMana;
            }

        }
        else // Drain
        {
			currentHealth -= y;
            mana.value = currentMana;
        }
    }

    public void infamySlider(float x)
    {
        Infamy.value += x;
    }
}
