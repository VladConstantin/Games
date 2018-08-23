using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    //gameController gc = new gameController();

    public Text backStory;
    public static int character;
    public static int diff;
    public GameObject playGame;
    public GameObject winScreen;
    public Text WinCondition;
    public bool inShop = false;
    public bool inTavern = false;
    public bool inCombat = false;

    public void selectCharacter(int x)
    {
        switch (x)
        {
            case 1:
                character =  1;
                backStory.text = "\n \n Garren, \n \n \n A brave solder who once was enrolled in the royal army, but after an unfortunate brawl in the bar, he killed someone and got sent to jail. He was sentenced to death by hanging, but he can redeem  his honor and freedom. \n \n \n Unlock by purchasing DLC";
                break;
            case 2:
                character = 2;
                backStory.text = "\n \n Ingrid, \n \n \n In those times mages were considered evil no matter whay and our protagonist found that the kingdom holds very powerful powers. \n \n \n Unlock by purchasing DLC";
                break;
            case 3:
                character = 3;
                backStory.text = "\n \n Hubert, \n \n \n He is a trained thief and a master of shadows, he was not actually captured by the king's guard. He snuck himself in the prison, no one really knows why he would do such a thing. \n \n \n Unlock by purchasing DLC";
                break;
            case 4:
                character = 4;
                backStory.text = "\n \n Oxi, \n \n \n For him it was the case of being in the wrong place at the wrong time. He was charged with theft and murder when he was heading home after returning  from his journey  from the mountains. He was seen coming from the place of the incident and as people have not seen him in a long time, everybody put the blame on the 'newcomer'.";
                break;
        }
    }

    public void difficulty(int x)
    {
        diff = x;
    }

    public void setEnterShop(bool x)
    {
        inShop = x;
    }

    public void setEnterTavern(bool x)
    {
        inTavern =x;
    }

    public void setEnterCombat(bool x)
    {
        inCombat = x;
    }

    public void mainStory()
    {
        backStory.text = "\n \n The story begins in a time long forgotten, \n when the King has lost his daughter to an evil witch. He does not know the true intentions of the witch all he knows is that he wants to get his daughter back no matter what. He has tried desperately to save her by sending men and by putting a healthy price on the witch’s head, but in the end it was futile. He grew desperate and he found himself out of options, so as a last resort he started sending prisoners on death row to try to do the impossible.";
    }

    public void Begin(GameObject menu)
    {
        playGame.gameObject.GetComponent<gameController>().prepareGame(character);
        menu.SetActive(false);
    }

    public void correctCharacteroptions(int x)
    {
        switch (character)
        {
            case 1:
                //playGame.gameObject.GetComponent<warrior>().options(x);
                break;
            case 2:
                //playGame.gameObject.GetComponent<mage>().options(x);
                break;
            case 3:
                //playGame.gameObject.GetComponent<rogue>().options(x);
                break;
            case 4:
                if (inShop == true)
                {
                    playGame.gameObject.GetComponent<shop>().options(x);
                }
                else if(inTavern == true)
                {
                    //playGame.gameObject.GetComponent<monk>().options(x);
                }
                else if(inCombat == true)
                {
                    playGame.gameObject.GetComponent<enemies>().options(x);
                }
                else
                {
                    playGame.gameObject.GetComponent<monk>().options(x);
                }

                break;
        }
            
    }

    public void WinGame(int x)
    {
        switch (x)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                winScreen.gameObject.SetActive(true);
                WinCondition.text = "You have reached the end of the playable demo! \n " +
                    "Hope you enjoyed the game. \n " +
                    "Please don't forget to pre-purchase for extra content and also there is a season pass coming out \n" +
                    "Oh, and let's not forget the loot boxes that you will get";
                break;
            case 4:
                winScreen.gameObject.SetActive(true);
                WinCondition.text = "You Discovered the monk secret ending! \n " +
                    "Monks are reasonable people and should be able to live peacefully. \n " +
                    "They do not need any adventures all they want is peace.";
                break;
        }
    }
}
