using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour {

    public GameObject gc;

    private int priceWeapons;
    private int priceHelmet;
    private int priceChest;
    private int priceLegs;
    private int priceShoes;

    public Text displeyItems;
    public Text option1;
    public Text option2;
    public Text option3;
    public Text option4;
    public Text option5;

    private int option = 1;

    public void enter(int x)
    {
        gc.gameObject.GetComponent<MainMenu>().setEnterShop(true);
        if (x == 1)
        {
            displeyItems.text = "Sailsmen: Hello, what may I interest you in? \n " +
                    "We've got fresh stock";
            option1.text = "Weapons";
            option2.text = "Armour";
            option3.text = "Potions";
            option4.text = "Leave";
            option5.text = "";
            option = 1;
        }
        else if (x == 2) //weapons
        {
            displeyItems.text = "Sailsmen: This is what we have \n " +
                    "Sword and Shield 50 \n " +
                    "Daggers 50 \n " +
                    "Staff 50 \n " +
                    "Brass Knuckles 50 \n" +
                    "You thought that you have money for these!?";
            option1.text = "Buy Sword and Shield";
            option2.text = "Buy Daggers";
            option3.text = "Buy Staff";
            option4.text = "Buy Brass Knuckles";
            option5.text = "Back";
            option = 2;
        }
        else if (x == 3) //armour
        {
            displeyItems.text = "Sailsmen: This is what we have \n " +
                    "Helmet 80 \n " +
                    "Chest 120 \n " +
                    "Leggings 55 \n " +
                    "Shoes 40 \n" +
                    "You thought that you have money for these!?";
            option1.text = "Upgrade Helmet";
            option2.text = "Upgrade Chest";
            option3.text = "Upgrade Leggings";
            option4.text = "Upgrade Shoes";
            option5.text = "Back";
            option = 3;
        }
        else if (x == 4) // potions
        {
            displeyItems.text = "Sailsmen: This is what we have \n " +
                    "Hp potion 40 \n " +
                    "Mana Potion 35 \n " +
                    "Attack Up 40 \n " +
                    "Defensive Up 40" +
                    "You thought that you have money for these!?";
            option1.text = "Buy Hp potion";
            option2.text = "Buy Mana Potion";
            option3.text = "Buy Attack Up";
            option4.text = "Buy Defensive Up";
            option5.text = "Back";
            option = 4;
        }
        else if (x == 5) //items
        {
            gc.gameObject.GetComponent<monk>().backToStory();
            gc.gameObject.GetComponent<MainMenu>().setEnterShop(false);
        }
        else if (x == 6)
        {
        }
    }

    public void options(int x)
    {
        
        if (option == 1) //Main menu
        {
            if (x == 1)
            {
                enter(2); //weapons
            }
            else if(x == 2)
            {
                enter(3); //armour
            }
            else if(x == 3)
            {
                enter(4); // potions
            }
            else if(x == 4)
            {
                enter(5); // items
            }
            else if( x == 5)
            {
                enter(6); // leave
            }
        }
        else if (option == 2) //weapons
        {
            if (x == 1)
            {
                
            }
            else if (x == 2)
            {
               
            }
            else if (x == 3)
            {
               
            }
            else if (x == 4)
            {
                
            }
            else if (x == 5)
            {
                enter(1); // leave
            }
        }
        else if (option == 3) //armour
        {
            if (x == 1)
            {
                
            }
            else if (x == 2)
            {
                
            }
            else if (x == 3)
            {
                
            }
            else if (x == 4)
            {
                
            }
            else if (x == 5)
            {
                enter(1); // leave
            }
        }
        else if (option == 4) //potions
        {
            if (x == 1)
            {
                
            }
            else if (x == 2)
            {
               
            }
            else if (x == 3)
            {
                
            }
            else if (x == 4)
            {
                
            }
            else if (x == 5)
            {
                enter(1); // leave
            }
        }
        
    }
}

