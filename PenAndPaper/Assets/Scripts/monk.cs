using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class monk : MonoBehaviour {

    public GameObject gc;

    public Text dialog;

    public Text option_one;
    public Text option_two;
    public Text option_three;
    public Text option_four;
    public Text option_five;

    public int storyPoint; //keeps track of the story sequence

    public int saveNarativePoint;
    public int saveNarativeChapter;

    public void backToStory()
    {
        
        if (saveNarativeChapter == 1)
        {
            chapterOne(saveNarativePoint);
        }
        else if (saveNarativeChapter == 2)
        {
            //chapterTwo(saveNarativePoint);
        }
        else if (saveNarativeChapter == 3)
        {
            //chapterThree(saveNarativePoint);
        }
        else if (saveNarativeChapter == 4)
        {
            //chapterFour(saveNarativePoint);
        }

    }

    public void redo()
    {
        kingsTrust = false;
        generalInsulted = false;
        generalOnYourSide = false;
    }

    //EXPO GAINED
    private bool kingsTrust = false;
    //Chapter 1 Gained
    private bool generalInsulted = false;
    private bool generalOnYourSide = false;
    private bool helpedBilly = false;
    private bool upsetBilly = false;
    //Chapter 2 Gained
    private bool freeAle=false;
    private bool insultedWorkers = false;
    private bool youHurtkailEgo = false;
    private bool knowAboutXavier = false;

    /*========================================EXPO================================================================================*/
    public void monkExpo(int x)
    {
        if (x == 1)
        {
            dialog.text = "*You are sitting in you cell, in meditation. Thinking about the fact that maybe the Gods have put you in here for a reason. * \n" +
                 "*You hear the cell door unlock* \n" +
                 "Guard1: you are coming with us \n" +
                 "*They put shackle on your arms and legs and make you walk with them* \n" +
                 "Guard1: What's his deal? \n" +
                 "Guard2: Common thief and a murderer, kings pretty desperate to send him on the mission";

            option_one.text = "Say nothing"; // 11
            option_two.text = "Explain your situation"; //12
            option_three.text = "Ask what's going on"; //13
            option_four.text = "Try to escape"; //14
            option_five.text = "Insult them"; //15
            storyPoint = 1;
        } else if (x == 11)  //say nothimg
        {
            dialog.text = "Guard1: Don't run your mouth like that, his daughter got kidnapped and if he hears you he might have you killed. \n " +
                "Guard2: Yeah, you're right.";

            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 11;

        } else if (x == 12) //explain yourself
        {
            dialog.text = "You: It is not me the one that you are speaking of, you have made a mistake. \n " +
                        "Guard1: Shut up, you got caught at the place of the murder. \n " +
                        "Guard2: And if you don't keep your mouth shut, I'll shut if for you. \n" +
                        "*Best see this keep quiet for now, I might be able to reason with the king*";

            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 11;

        } else if (x == 13) //ask what is going on
        {
            dialog.text = "You: Where are you taking me? \n " +
            "Guard1: You do not get to ask questions. \n " +
            "Guard2: Also, when you get in front of the king you best keep your mouth shut and listen. You scum are not worthy of talking to him. \n" +
            "*The king? I might be able to plea my case to him*";

            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 11;
        }
        else if (x == 14) //try to escape
        {
            dialog.text = "*You have shackles on your hands and feet, you try to break loose but you are not strong enough* \n " +
            "Guards: HAHAHA! \n " +
            "Guard2: That was pitiful, now be good before we decide to kill you instead. \n " +
            "*Well that was useless, I guess I have to wait and see what happens next*";

            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 11;
        }
        else if (x == 15) //insult them
        {
            dialog.text = "You: You imbeciles, you have the wrong guy \n" +
            "Guard1: Who are you calling useless? \n " +
            "*Guard2 back-hands you* \n " +
            "Guard2: This will teach you to run your mouth! \n" +
            "Guard1: You best behave yourself in front of the king. \n " +
            "Guard2: Also on the next one I will not be so forgiving \n " +
            "*I cannot make these idiots see reason, I have to be patient and improvise*";

            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 11;
        }
        else if (x == 2) //King room
        {
            dialog.text = "*You are in front of a huge door. One of the guards slowly opens it and it leads into the throne room* \n " +
                "*You are now in front of the king* \n" +
                "Guard2: Your majesty this is the last strong looking bloke in the jail \n" +
                "King: What has he been accused of? \n" +
                "Guard2: He is a murder...";

            option_one.text = "Correct him (calmly)";
            option_two.text = "Correct him (angry)";
            option_three.text = "Let Him Finish";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 12;

        }
        else if (x == 21) //Correct him (calmly)
        {
            dialog.text = "You: I am not a murderer, this is an injustice, I am not...  \n" +
             "Guard2: Shut your mouth you filthy ... \n" +
             "King: SILENCE! I do not care of your truth, I only wish to see my daughter again. \n" +
            "It has been far too long since I last saw her, this is my offer, no matter what you did, you will be set free and rewarded if you manage to bring her back";


            option_one.text = "Agree to his terms";
            option_two.text = "Disagree";
            option_three.text = "Nod";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 13;

        }
        else if (x == 22) //Correct him (angry)
        {
            dialog.text = "You: This is outrageous, I was accused of something I did not do, your men have no proof that I did anything...  \n" +
            "Guard2: Shut your mouth you filthy mo... \n" +
            "King: SILENCE! I do not care of the truth, I only wish to see my daughter again. \n" +
            "It has been far too long since I last saw her, this is my offer, no matter what you did, you will be set free and rewarded if you manage to bring her back";


            option_one.text = "Agree to his terms";
            option_two.text = "Disagree";
            option_three.text = "Nod";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 13;

        }
        else if (x == 23) //Let Him Finish
        {
            dialog.text = "Guard: ...murderer and a thief, he is sentenced to hang in three sunrises.  \n" +
            "King: Are you sorry for your actions? \n";


            option_one.text = "Yes (sarcastic)";
            option_two.text = "No (WIZ)";
            option_three.text = "Explain yourself";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 14;

        }
        else if (x == 241) //Agree to his terms
        {
            dialog.text = "You: I will accept your offer If you can ensure that I will be released at the end of this. \n" +
                "Guard1: You dare questioning his roy... \n" +
                "King: You need to stop talking when you are not asked. To answer your question. \n" +
                "King: I promise, you will be pardoned, you have my word and in any case, you don’t really have I choice. It's either this or death. " +
                "You: Fair point, I guess I'll have to hear more about what it is that I need to do.";


            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 15;
        }
        else if (x == 242) //Disagree
        {
            dialog.text = "You: I shall do no such thing, I have been convicted wrongly and I wish to be set free this instance! \n" +
                "Guard1: You dare defy his hi... \n" +
                "King: You need to stop talking when you are not asked. To answer your question. \n" +
                "King: You do not have a choice, I just wished we would have struck a bargain, I have other methods to make you obey me. Your family for example, but I do not wish to use such threats if not need be. \n" +
                "You: Hmm, I guess I have no choice. Well then, tell me about this journey.";


            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 15;
        }
        else if (x == 243) //Nod
        {
            dialog.text = "King: Good, I like you. The ones before you, a barbarian that kept running his mouth, a mage that was too wise for his own good and a thief that wasn't as slick as he believed  \n"
                + "King: But you, I like you. I have a feeling that you are a reasonable man. As I said your convictions don't matter right now, they will be erased either way if you bring my daughter back. \n";


            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 15;

        }
        else if (x == 231) //33 Yes(sarcastic)
        {
            dialog.text = "You: Yes, I take full responsibility. I let myself dragged for no good reason and imprisoned for a crime I did not commit. I thought I could reason but I wasn't even offered a trial... \n" +
                "King: Enough I do not want to hear this. I will not stand for this insolence. Take him back. \n" +
                "You: Wait! I have let anger cloud my mind, I will take your quest. \n" +
                "King: It's good to know you can see reason. Although you were facing death. But for some reason I like you more than the previous 3 \n" +
                "You: Tell me more about this journey.";


            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 15;
        }
        else if (x == 232) //33 No
        {
            dialog.text = "You: I cannot feel sorrow for something I did not do. But I will face judgment, if that's what is to be my faith as it was decided by the Gods. \n" +
                "King: For some reason, I believe you. Even still, if not because you were sentenced to death, you can still help me for the reward. \n" +
                "You: I am a monk, I do not have a desire for earthly possessions, I only seek tranquility." +
                "King: I see. Well then, I apologies for this inconvenience. \n" +
                "Guards: Your highness? \n" +
                "King: Do not question me, you have convicted this man wrongly. If you would have just interrogated him before conviction you would have reached the same conclusion it out. " +
                "But maybe this as you said your destiny, you were brought in front of me by the Gods to help me. \n" +
                "You: It could be. You are a wise king and an understanding one, I can only imagine your grief. I will do it, I will find your daughter. Tell me what needs to be done.";


            kingsTrust = true;

            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "Decide to carry on with your life";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 15;
        }
        else if (x == 233) //33 Explain Yourself
        {
            dialog.text = "You: I can't imagine the grief you are in. But this is a mistake, I did not do the crimes I was convicted of. \n" +
                "King: I do not care, I hear those same words coming out of each and every one of the prisoners that get put in front of me. " +
                "I only want to know if you will help me or not. It would not matter either way if you were guilty or not, all will be pardoned if you bring my daughter back. \n" +
                "You: Well, is that my only option?" +
                "King: Yes, but you can still choose to carry out your sentence Which is? *Looks at Guards*. \n" +
                "Guard1: To be hanged in three sunrises from today. \n " +
                "You: I will help you, not because I fear death, I am at peace with all that I have done, but because I do not wish my name to be stained with such lies. Tell me what I must do";


            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 15;
        }
        else if (x == 3)
        {
            dialog.text = "King: Ok, the journey will be hard, I am not going to lie. Many brave warriors have fallen on this quest. " +
                "You must go through the Enchanted Forest, past the Pik Mountain around the Old Lake and then you will reach the tower where my daughter is being kept. \n" +
                "You: This is a long journey, I will require some equipment and some rations. \n" +
                "King: They will be handed to you, and a better brief will be given by my general. Also, if you do not plan on coming back, if at any point you decide that you can just abandon this quest, just remember that I have other ways to punish you. " +
                "And I will know if you fled or died \n" +
                "You: I do not go back on my word, there is no need for such threats. \n." +
                "*King makes a hand gesture and you get escorted to the general*";


            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 2;
        }
    }

    /*========================================Chapte1================================================================================*/

    public void chapterOne(int x)
    {
        saveNarativeChapter = 1;
        if (x == 1)
        {
            dialog.text = "*The guards take you to the general, tall bloke, dark hair and a face that can easily portray a man that has seen his fair share of death. * \n" +
                "General: So, you are the last one huh? You know what I think, what the king is doing is smart, " +
                "why send us when he can send you scum, you will die either way.";


            option_one.text = "Don't care";
            option_two.text = "Explain yourself";
            option_three.text = "Get to the point";
            option_four.text = "Say Nothing";
            option_five.text = "";

            storyPoint = 21;
        }
        else if (x == 11) //Don't care
        {
            dialog.text = "You: I did not ask for your opinion. I was brought here to be briefed, not to listen to your 'opinions'. \n" +
                "General: You think you are a wise-ass? \n" +
                "You: Enough, as I said. Brief me and gear me and I will be on my way... \n" +
                "General: Eager to die? Fine by me. You ungrateful bastards don't know when to shut up, the three before you were running their mouths as well. You need to learn your place. \n" +
                "You: I assume you are done? \n" +
                "General: If you weren’t going on the Kings quest, I would have killed you. Well I hope you die by the hand of the witch, I hear she likes to experiment on the people before she kills them.";


            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";
            generalInsulted = true;
            storyPoint = 22;
        }
        else if (x == 12) //Explain yourself
        {
            if (kingsTrust == true)
            {
                dialog.text = "You: I am innocent. \n" +
                 "General: So, say all of you lot that get sent to slaughter \n" +
                 "You: Well your king believes so. I am doing this of my own will. \n" +
                 "General: What? Don't make me laugh. \n" +
                 "Guard2: He is speaking the truth \n" +
                 "General: Well you are either a fool or in it for the gold. \n " +
                 "You: Does not matter. \n " +
                 "Guard: That is true. Let me get on with your brief";

                generalOnYourSide = true;
            }
            else
            {
                dialog.text = "You: I am innocent. \n" +
                    "General: So, say all of you lot that get sent to slaughter \n" +
                    "You: Your men have made a mistake. \n" +
                    "General: I wouldn't make accusations of such sort if I were in your position. \n" +
                    "You: Does not matter now. I will clear my name. Proceed with the briefing \n " +
                    "General: Eager to die? Fine by me. here is what you need to know";

            }

            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 22;
        }
        else if (x == 13) //Get to the point
        {
            dialog.text = "You: Let's skip the chit-chat, get on to the point, I assume we both have places to be and things to do. \n" +
                 "General: My time is far more important than yours scum! Do not compare me to you \n" +
                 "You: I am going to rescue the king’s daughter, one might say my time might be far more precious \n " +
                 "General: You insolent fool! Hmmm... I do not have time to mock about I'll tell you what you need to know.";



            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 22;
        }
        else if (x == 14) //Say Nothing
        {
            dialog.text = "General: Quiet one? Are you mute or something? Eh, you know what I don't care." +
                "Here is what you need to know.";

            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 22;
        }
        else if (x == 15) // DO THE TUTORIAL?
        {
            dialog.text = "*DO YOU WISH TO HAVE A BREIF ON THE INTERFACE? *";

            option_one.text = "Yes";
            option_two.text = "No";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 23;
        }
        else if (x == 16) //Tutorial
        {
            dialog.text = " \n *The interface is labeled accordingly* \n " +
            "*The attributes modify your combat performance, your persuasion skills and your overall experience* \n " +
            "*ARM - Armor (how high is your armor) * \n" +
            "*STR - Strength (how high is your health and if you are a Warrior, this is the attack modifier) * \n" +
            "*DEX - Dexterity (if you are a Monk or Rogue this is the attack modifier) * \n" +
            "*INT - Inteligence (how high is your mana, and if you are a Mage, this is the attack modifier) * \n" +
            "*CHA - Charisma (higher this attribute is, the character can persuade the others more easily) * \n" +
            "*WIZ - Wisdom (higher this attribute is, the character may gain extra information in puzzles or quizzes) * \n" +
            "*Initiative - determines who goes first in combat* \n " +
            "*Drunken Style - increases the armor for 2 turns during combat* \n " +
            "*Body Knowledge - increases the attack for 2 turns during combat* \n " +
            "*Quivering Palm - can stun the oponent for the next turn* \n " +
            "*Tranquility - passive ability which increases the DEX attribute* \n " +
            "*The sliders that display your life and mana total are pretty straight forward.* \n " +
            "*Infamy keeps track of your choices when out in the open. Your decisions matter and based on them people might perceive you differently* \n";

            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 24;
        }
        else if (x == 17) // BREIF
        {
            if(generalInsulted == true)
            {
                dialog.text = "General: Alright, you need to go through the Enchanted forest, in and out Pik Mountain, around the Old Lake and you should find the tower. \n " +
                     "You: this is my brief? You gave me nothing." +
                     "General: Your time is precious, isn't it? I kept it short. \n " +
                     "You: If I fail because of you. I will remember. \n " +
                     "General: Yeah? See you in hell \n " +
                     "You: ... just give me my gear and supplies \n " +
                     "General: they are over there. \n " +
                     "*You receive normal clothes and a broken sword, 10 gold and a potion of healing* \n " +
                     "You: You must be joking? this is it? \n " +
                     "General: Not good enough for you? That's all you going to get. \n " +
                     "You: You can keep the sword. I fight better with my hands. Now if that's all I'm going to get, I'll be on my way." +
                     "General: Best of luck, you useless scum.";

                gc.gameObject.GetComponent<playerHandeler>().setGold(20, 1, 0);

            }
            else if (generalOnYourSide == true && generalInsulted == false)
            {
                dialog.text = "General: Ok, here is what you need to know. \n " +
                   "There are three landmarks that you must pass. \n " +
                   "First the Enchanted Forest, mystical place. You will see creatures of the old tales roaming around there. From what I hear there is something shady going on over there. \n " +
                   "Second the Mountain called Pik. It is a point of great foes. Mostly trolls and goblins, but there are tales of a rare item, keep your eyes and ears open someone might know how to get to it. \n " +
                   "Third the Old Lake, i know what you must think, just the Old Lake, it used to have a name, but it has long been forgotten, they say a big beast lives somewhere around there, see if you can find someone that knows. \n " +
                   "Now after the lake you should be able to see the tower, from what we know she has no weakness, but you may figure something out. \n " +
                   "You: Ok, I will be careful, where is my gear? \n " +
                   "General: Over there on the table. \n " +
                   "*You received light armor, brass knuckles, 10 gold, 1 potion of healing and 1 of mana* \n " +
                   "You: Thank you, my weapon of choice. I will be on my way if that's all \n " +
                   "General: Yes, that is all. Good luck on your travels.";

                gc.gameObject.GetComponent<playerHandeler>().setGold(20, 1, 1);
                //give weapon lvl +2
                //armour lvl +1
            }
            else
            {
                dialog.text = "General: Ok, here is what you need to know. \n " +
                   "There are three landmarks that you must pass. \n " +
                   "First the Enchanted Forest, mystical place. You will see creatures of the old tales roaming around there. \n " +
                   "Second the Mountain called Pik. It is a point of great foes. Mostly trolls and goblins. So, watch your back and your pockets \n " +
                   "Third the Old Lake, I know what you must think, just the Old Lake, it used to have a name, but it has long been forgotten, you not need concern yourself with tales. \n " +
                   "Now after the lake you should be able to see the tower, you just have to fight the witch, easier said than done. \n " +
                   "You: Ok, I will be careful, where is my gear? \n " +
                   "General: Over there on the table. \n " +
                   "*You received light used up armor, a sword, 10 gold, 1 potion of healing and one of mana* \n " +
                   "You: Thank you. I will be on my way \n ";

                gc.gameObject.GetComponent<playerHandeler>().setGold(20, 1, 1);
                //armour lvl +1
                //weapon +2
            }

            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 25;
        }
        else if (x == 18) //general store 
        {
            dialog.text = "*You have left the palace. You are walking across the kingdoms grounds, heading towards the exit gate* \n " +
                "*While walking you spot a general store and the general shop*" +
                "\n *general stores in this game include armor and weapon upgrades*";
            option_one.text = "";
            option_two.text = "Go in general shop";
            option_three.text = "Leave kingdom";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 26;
        }
        else if (x == 19) // theif first battle encounter
        {
            dialog.text = "*You proceed outside the kingdom and you are making your way down to the Enchanted forest* \n" +
                "*While walking you hear a person approaching you from behind, you turn around and notice someone* \n " +
                "Stranger: Hello traveler, where are you headed? What is your name?  \n ";

            option_one.text = "None of your buisiness";
            option_two.text = "Respond";
            option_three.text = "First who are you, then I tell you who I am";
            option_four.text = "Keep walking";
            option_five.text = "";

            storyPoint = 27;
        }
        else if (x == 20) // none of your buisiness
        {
            dialog.text = "You: This is not your concern. \n " +
                "Stranger: Well then, aren't you an important person. Are you? \n " +
                "You: No. And as I said it is not your concern. \n " +
                "Thief: Well then, if you are not going to tell me, I'll kill you and take everything you have from your dead body!";

            option_one.text = "";
            option_two.text = "Fight";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 28;
        }
        else if (x == 21) //respond
        {
            dialog.text = "You: I am Oxi, I took the kings quest to save his daughter. \n" +
                "Thief: Did you now? Well if the king sent you, you must have some rations or potions or even gold. Now let me have them! \n " +
                "You: I would not advise to try to fight me. \n " +
                "Thief: I am going to kill you!";

            option_one.text = "";
            option_two.text = "Fight";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 28;
        }
        else if(x == 22) //first you then I 
        {
            dialog.text = "You: You're the one who started the conversation. Who are you? \n " +
                "J: I am John, but people call me J. I am just going to the tavern ahead. \n " +
                "You: Well John, I am on a quest from the king to save his daughter. Do you know any information that might be of use on my journey? \n " +
                "J: Yes, be very careful about the thieves. They are everywhere, you don't know when they might ATTACK!";

            option_one.text = "";
            option_two.text = "Fight";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 28;
        }
        else if(x == 23) //Defeated the theif
        {
            dialog.text = "You: You were a fool to think you can beat me! \n " +
                "*You gained 25 XP* \n " +
                "*LEVEL UP* \n " +
                "*You attributes have been updated and you have 1 skill point available*";
            gc.gameObject.GetComponent<playerHandeler>().setSkillPoint(1);
            gc.gameObject.GetComponent<playerHandeler>().lvlUp();
            gc.gameObject.GetComponent<gameController>().setAttribute();
            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 29;
            gc.gameObject.GetComponent<playerHandeler>().infamySlider(0.3f);
        }
        else if (x == 24) //meet billy
        {
            dialog.text = "*On your way to the enchanted forest you hear a cry for help* \n " +
                "*When you try to detect the origin of the sound you spot a person trapped under a tree* \n " +
                "Stranger: Hey, YOU! Aahhh. Can you please help me? \n " +
                "You: How did you get in this predicament? \n" +
                "Person: I was trying to cut down a tree for the fire, can you please help me? If you do I will give you my pouch. \n" +
                "*You can see the pouch next to him*";

            option_one.text = "";
            option_two.text = "Help him";
            option_three.text = "Move along, not your concern";
            option_four.text = "Take the pouch and walk away";
            option_five.text = "";

            storyPoint = 30;
        }
        else if(x == 241) //help him
        {
            dialog.text = "*With one gesture you approach him and help lift the log off his leg* \n" +
                "You: Does it hurt? \n" +
                "Billy: No, I was lucky, thank you. By the way my name is Billy. \n " +
                "You: I am Oxi. \n " +
                "Billy: As promised you can have my pouch";
            option_one.text = "";
            option_two.text = "No, thank you";
            option_three.text = "You are a man of your word";
            option_four.text = "";
            option_five.text = "";
            helpedBilly = true;
            storyPoint = 31;
            gc.gameObject.GetComponent<playerHandeler>().infamySlider(0.3f);
        }
        else if (x == 2411) // refuse gift
        {
            dialog.text = "You: Keep your items, I do not need any prize for helping a man in need. \n " +
                "Billy: You are truly a good person, rare to find people like you. Well then, I must head off. \n" +
                "My family is waiting. Thank you again for all your help. \n " +
                "You: Let's hope our path will meet again";

            option_one.text = "";
            option_two.text = "Continued";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";
            
            storyPoint = 32;
        }
        else if (x == 2412) // accept gift
        {
            dialog.text = "You: Thank you for your generosity. I will use them wisely. \n " +
                "Billy: No worries, God knows how long I would have been stuck under that tree if you didn’t show up. \n " +
                "You: Well then maybe it was faith that let me to find and help you. \n " +
                "Billy: Ey, that could be. I wish I could stay and chat but my family is waiting for me. Maybe our paths will cross again. \n " +
                "You: Maybe so, we will see if it is destined.";

            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 32;
        }
        else if(x == 242) //move along 
        {
            dialog.text = "*You start walking away from the stranger* \n " +
                "Stranger: What you are just going to leave me? \n " +
                "You: It is not my concern. I did not put you under that tree it is not my duty to pull you out. \n" +
                "*You walk away leaving the stranger behind* ";
            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 32;
        }
        else if (x == 243) //steel his stuff
        {
            dialog.text = "*You reach for his pouch, look back at him and start walking away* \n " +
                "Stranger: YOU THEIF, GIVE THAT BACK! I said I would give it to you if you helped me. \n" +
                "You: Yes, but I can take it either way, I found it on the ground, how can you prove this was yours? \n" +
                "Stranger: Why you scum! \n " +
                "*You walk away hearing the curses from the stranger you left behind*";
            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";
            upsetBilly = true;
            storyPoint = 32;
            gc.gameObject.GetComponent<playerHandeler>().infamySlider(-0.3f);
        }
        else if (x == 25) // procede to chaptertwo
        {
            dialog.text = "*As you approach the entrance of the Enchanted Forest you spot a tavern it would be a good place to find information* \n " +
                "*You can also see some men unloading some barrels from a carriage* ";

            option_one.text = "";
            option_two.text = "Go to the tavern";
            option_three.text = "Walk in the forest";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 33;
        }
    }
    /*========================================ChapterTwo======================================================================*/

    public void ChapterTwo(int x)
    {
        if (x == 1) //went to tavern
        {
            dialog.text = "*You are now next to the tavern, the people unloading the barrels have spotted you* \n " +
                "*You could try speaking with them, they look like they know the forest* ";

            option_one.text = "Talk to the people";
            option_two.text = "Go inside the tavern";
            option_three.text = "Analyse the area";
            option_four.text = "Walk towards the Forest";
            option_five.text = "";

            storyPoint = 34;
        }
        else if (x == 11) //talk to the people
        {
            dialog.text = "You: Hello my good men. Can I bother you With a few questions? \n " +
                "Guy1: We are working over here. We do not have time to chat. \n " +
                "Guy2: If you give us a hand we might reconsider.";

            if (upsetBilly)
            {
                dialog.text += "Guy3: Say, don't he look like the guy that stole from Billy? \n" +
                    "Guy1: You don't even know how he looks so stop running your mouth";
            }

            option_one.text = "";
            option_two.text = "Help out";
            option_three.text = "Politely refuse";
            option_four.text = "Refuse (insult)";
            option_five.text = "";

            storyPoint = 341;
        }
        else if (x == 111) // help
        {
            dialog.text = "You: I'll give you a hand. \n " +
                "*You start unloading the barrels and putting them into a pile next to the tavern \n " +
                "You: Now what can you tell me about the forest? \n" +
                "Guy2: Apart from the fact that it's filled with bandits and mystical creatures there's not much that I know of. \n " +
                "Guy3: I did hear of a new presence in the woods. Someone roaming talking with everyone that comes in and out. \n " +
                "You: Something to worry about? \n " +
                "Guy3: I do not know to be honest. \n " +
                "*Guy1 puts down the last barrel* \n" +
                "Guy1: Thanks for the help, you can have some ale on the house if you come inside.";

            freeAle = true;

            option_one.text = "";
            option_two.text = "Go inside";
            option_three.text = "Head towards the forest";
            option_four.text = "";
            option_five.text = "";
            gc.gameObject.GetComponent<playerHandeler>().infamySlider(0.3f);
            storyPoint = 342;
        }
        else if (x == 112) //refuse politely
        {
            dialog.text = "You: No, I will leave you be. I do not wish to bother you. \n " +
                "Guy1: Good, now go on ey.";

            option_one.text = "";
            option_two.text = "Go inside tavern";
            option_three.text = "Head towards the forest";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 342;
        }
        else if (x == 113) //refuse rudely
        {
            dialog.text = "You: No, do not concern myself with such rudimentary tasks. I am on a quest from the king, either you tell me what you know or not speak a word. \n " +
               "Guy1: You're the kings new little disposable fetch dog? \n" +
               "Guy3: There is a man in the woods that... \n" +
               "Guy2: Shut up Barry, the man said to not speak a word. \n " +
               "Barry: Yes brother. \n " +
               "*Well they certainly won't help me now might as well move on*";
            gc.gameObject.GetComponent<playerHandeler>().infamySlider(-0.3f);
            insultedWorkers = true;

            option_one.text = "";
            option_two.text = "Go inside tavern";
            option_three.text = "Head towards the forest";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 342;
        }
        else if (x == 12)//go inside the tavern
        {
            dialog.text = "*You have entered the tavern. Cheerful music and loads of drunken people talking, as one might expect from such a place* \n" +
                "*You notice a man telling stories, seems like half the bar is listening to him* \n " +
                "*There is also the bartender, if anyone here knows any rumors it must be him*";

            option_one.text = "";
            option_two.text = "Go see hwat the fuss is about.";
            option_three.text = "Talk to the bartender";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 343;
        }
        else if (x == 121) // see the fuss
        {
            dialog.text = "*There is a man, you can hear the crowd whispering his name (Kail)* \n " +
                "kail: I did I tell you, I chased them all out of their hideout, go and check if you don't believe me. \n" +
                "Man Form the crowd: Id I do and they are still there? \n " +
                "kail: Well then, you will prove then I have lied *pauses for 3 seconds* But I do not lie my friend. Did I or did I not bring a dragon fang to this place? \n " +
                "Crowd: yeah (yeah) *some inaudible murmurs* \n" +
                "Kail: Did I or did I not chase the troll out of his cave so that we use the shortcut in Mount Pik without care? \n";

            option_one.text = "";
            option_two.text = "Ask about mount Pik Shortcut";
            option_three.text = "Go speak to the bartender";
            option_four.text = "";
            option_five.text = "";

            storyPoint = 344;

        }
        else if(x==1211) //ask bout Pik shortcut
        {
            dialog.text = "You: Excuse me, you just said there is a shortcut in mount Pik? \n " +
                "Kail: Yes, there is, do you wish to know about it? \n " +
                "You: Yes, please do tell. \n " +
                "Kali: Well let me tell you about the story when... *Here he goes again - you hear from the crowd*";

            option_one.text = "";
            option_two.text = "Let him finish";
            option_three.text = "Interupt and ask to cut to the point";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 345;
        }
        else if (x == 1212) //let him finish
        {
            dialog.text = "*After 20 minutes of Kail saying his tale, the only thing worth memorizing is never to ask him anything ever again. * \n " +
                "You: Thanks for that I have learned much about the mountain. \n " +
                "Person from the crowd: That's all he does, tell stories that are beside the point. \n " +
                "Kail: you dare challenge me? \n" +
                "You: Well I best be going, I’ve got some affairs to sort out.";
            option_one.text = "";
            option_two.text = "";
            option_three.text = "Go to Bartender";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 3451;
        }
        else if (x == 1213) //interupt him
        {
            dialog.text = "You: Can you cut to the question, I am in a rush. It would be of great value if you told me the shortcut. \n " +
                "Kail: very well, when you approach the mountain, there is a hidden path behind a bush, you can't miss it. The bush is blue. \n " +
                "You: Thank you for your information, well I best be on my way. \n " +
                "Kail: Good luck. *then keeps quiet while you walk away*";

            option_one.text = "";
            option_two.text = "";
            option_three.text = "Go to Bartender";
            option_four.text = "";
            option_five.text = "";

            youHurtkailEgo = true;

            storyPoint = 3451;
        }
        else if (x == 122) // ask bartender
        {
            if (insultedWorkers) 
            {
                dialog.text = "*You can see the bartender talking to the workers you met outside*" +
                "You: May I ask." +
                "Bartender: You may not. You think you can come here and ask whatever you want? Get out of my bar before we start a brawl and whoever beats you dead wins a keg on the goose" +
                "*You look around and you are clearly outnumbered, you decide to leave the bar*";

            }
            else if (freeAle)
            {
                dialog.text = "*You can see the bartender talking to the workers you met outside*" +
                "Bartender: Eh, you're the one who helped my boys move the ale. Thank you and as promise one draft on the house." +
                "You: Thank you. Do you know any useful information about the forest, Mount Pik or the Old Lake?" +
                "Bartender: Ey, I know lots of things, but the order that you asked these, seems like you are heading to the witch’s tower. \n " +
                "You: Yes, I am attempting the kings quest \n " +
                "Bartender: So, you are a prisoner?";
                if(kingsTrust)
                {
                    dialog.text += "You: No, I told the king my case and he saw that I was convicted wrongly. \n " +
                        "Bartender: In that case you should know that going on the left side of the lake will take half the time to get there";
                }else
                {
                    dialog.text += "You: Yes, but wrongly accused, there is no point in explaining my case, I will be set free at the end of the journey either way \n " +
                        "Bartender: In that case you should know that going on the left side of the lake will take half the time to get there";
                }
            }

            dialog.text += " \n *best be heading to the forest now*";

            option_one.text = "";
            option_two.text = "";
            option_three.text = "Go to the forest";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 3452;
            
        }
        else if (x == 13)//Analyse the area
        {
            dialog.text = "*You see nothing much more of interest to you* \n " +
                "*But after looking again you see a shady figure watching you from the bar*";
        }
        else if (x == 14)//walk to the forest
        {
            dialog.text = "*I could go back, but maybe I don't need any information*";
            option_one.text = "";
            option_two.text = "Turn back to the tavern";
            option_three.text = "Go to the forest";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 346;
        }
        else if (x == 2) //going to forest
        {
            if (helpedBilly)
            {
                dialog.text = "*As you walk in the forest you see Billy* \n " +
                    "You: Hello friend good to see you. \n " +
                    "Billy: Yes, so our paths have crossed again \n " +
                    "You: What bring you here? \n " +
                    "Billy: just passing through, I need to reach the tavern \n " +
                    "You I just came from there";
            
                if (insultedWorkers)
                {
                    dialog.text += "had a bit of an argument with the workers over there";
                }
                else if (freeAle)
                {
                    dialog.text += "I got offered some free ale for helping out";
                }
                    dialog.text += " \n Billy: Well than good to know that you left an impression";

                option_one.text = "";
                option_two.text = "Any advice going forword";
                option_three.text = "";
                option_four.text = "";
                option_five.text = "";
                storyPoint = 351;
            }
            else if (upsetBilly)
            {
                dialog.text = "Billy: remember me, you left me stuck under a tree and stole my stuff, this is what you get now";
                gc.gameObject.GetComponent<playerHandeler>().infamySlider(-0.3f);
                option_one.text = "";
                option_two.text = "Fight";
                option_three.text = "";
                option_four.text = "";
                option_five.text = "";
                storyPoint = 352;
            }
            else
            {
                dialog.text = "Stranger: Oh, it's you. \n " +
                    "You: So, I see you go out from under the log then. \n " +
                    "Stranger: Yeah, but no thanks to you \n" +
                    "You: Well then shall we keep to our own business? \n" +
                    "Stranger: Yes, I hope you get lost in the forest. \n" +
                    "*He leaves before you can exchange nay other sentences*";
                
                option_one.text = "";
                option_two.text = "Continue in the forest";
                option_three.text = "";
                option_four.text = "";
                option_five.text = "";
                storyPoint = 3521;
            }
        }
        else if(x == 21) // billy talks some adive
        {
            dialog.text = "Billy: Now that you ask, you should know about Xader. \n " +
                "You who is he? \n " +
                "Billy: Nobody knows but he is, or where he came from, all that you need to know is that he can not to be trusted. \n";
            knowAboutXavier = true;
            option_one.text = "";
            option_two.text = "Thanks Billy and continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 3521;
        }
        else if (x == 211) //won against billy
        {
            dialog.text = "Pour soul never stood a chance";
            option_one.text = "";
            option_two.text = "Continue";
            option_three.text = "";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 3521;
        }
        else if(x == 22) // continue into the woods
        {
            
            if (knowAboutXavier)
            {
                dialog.text = "*To no surprise you saw the man Billy was talking about Xader* \n " +
                    "Xader: Hello traveler what brings you to this neck of the woods?";

                option_one.text = "";
                option_two.text = "Attack him";
                option_three.text = "Say you know about him";
                option_four.text = "Withhold information";
                option_five.text = "";
                storyPoint = 3531;

            }
            else
            {
                dialog.text = "*You see a strange figure approaching, he is human, but you can feel a strange aura about him. * \n " +
                    "Stranger: Hello traveler what brings you to this neck of the woods?";

                option_one.text = "";
                option_two.text = "Tell the truth";
                option_three.text = "Hunch about who he might me";
                option_four.text = "Continue walking (ignore him)";
                option_five.text = "";
                storyPoint = 3532;
            }
        }
        else if (x == 221) //attack him
        {
            dialog.text = "*You try to attack but your sense of danger grows, you suddenly feel week* \n " +
                "*Maybe I Should do something else* \n" +
                "*Xader gives an evil grin*";

            option_one.text = "";
            option_two.text = "";
            option_three.text = "Say you know about him";
            option_four.text = "Withhold information";
            option_five.text = "";
        }
        else if (x == 222) //say you know about him
        {
            dialog.text = "You: I know who you are \n " +
                "Xader: Do you now? \n " +
                "You: I have been warned about you \n " +
                "Xader: Well this is no fun, I can't play with you anymore";

            option_one.text = "";
            option_two.text = "";
            option_three.text = "Continue";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 41;
        }
        else if (x == 223) //Withold information
        {
            dialog.text = "You: Hello stranger, I am Oxi, I am just passing by I need to reach Pik Mountain \n " +
                "Xader: Do you now? \n " +
                "You: Yes, I am actually in a bit of a rush \n " +
                "Xader: Well then you wouldn't mind if I tag along?";

            option_one.text = "";
            option_two.text = "";
            option_three.text = "Continue";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 41;
        }
        else if (x == 224) //tell him everything
        {
            dialog.text = "You: I know who you are \n " +
                "Stranger: Do you now? \n " +
                "You: I have been warned about you \n " +
                "Xader: Well let me introduce myself I am Xader, I live in these woods, I know shortcuts, I can take you to peek mountain quick.";

            option_one.text = "";
            option_two.text = "";
            option_three.text = "Continue";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 41;
        }
        else if (x == 225) //hunch about who he is
        {
            dialog.text = "You: I think I know who you are \n " +
                "Stranger: Do you now? \n " +
                "You: You are the wonderer of these woods people say you are a very chatty person \n " +
                "Xader: Well that's me, ha-ha, I'm Xader by the way. \n" +
                "You: Oxi, why are you in these woods? \n " +
                "Xader: I live here.";

            option_one.text = "";
            option_two.text = "";
            option_three.text = "Continue";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 41;
        }
        else if (x == 226) // continue walking
        {
            dialog.text = "Stranger: Some people might take offense to what you just did.  \n " +
                "Xader: Do you now? \n " +
                "You: I have been warned about you \n " +
                "Xader: Well this is no fun, I can't play with you anymore";

            option_one.text = "";
            option_two.text = "";
            option_three.text = "Continue";
            option_four.text = "";
            option_five.text = "";
            storyPoint = 41;
        }
    }

    /*========================================OPTION CONTROLLER======================================================================*/
    public void options(int x)
    {   //EXPO PART 1
        if (storyPoint == 1) // guard talking
        {
            if (x == 1)
            {
                monkExpo(11);
            }
            else if (x == 2)
            {
                monkExpo(12);
            }
            else if (x == 3)
            {
                monkExpo(13);
            }
            else if (x == 4) 
            {
                monkExpo(14);
            }
            else if (x == 5) 
            {
                monkExpo(15);
            }
        }
        else if(storyPoint == 11) //after th 5 guard intereactions
        {
            if (x == 2)
            {
                monkExpo(2); //continue
            }
        }
        else if (storyPoint == 12) // they are saing your conviction
        {
            if (x == 1)
            {
                monkExpo(21); // Correct him (calmly)
            }
            else if (x == 2)
            {
                monkExpo(22); //Correct him (angry)
            }
            else if (x == 3)
            {
                monkExpo(23); //Let Him Finish
            }
        }
        else if (storyPoint == 13) // //Correct him
        {
            if (x == 1)
            {
                monkExpo(241); // Agree to his terms
            }
            else if (x == 2)
            {
                monkExpo(242); // Disagree
            }
            else if (x == 3)
            {
                monkExpo(243); // Nod
            }
        }
        else if(storyPoint == 14) // Let Him Finish
        {
            if (x == 1)
            {
                monkExpo(231); // Yes(sarcastic)
            }
            else if (x == 2)
            {
                monkExpo(232); // No
            }
            else if (x == 3)
            {
                monkExpo(233); // Explain Yourself
            }
        }
        else if (storyPoint == 15) //Explain the jurney
        {

            if (x == 2)
            {
                monkExpo(3); // Continue
            }
            else if (x == 3)
            {
                gc.gameObject.GetComponent<MainMenu>().WinGame(4);
            }

        }

        if(storyPoint == 2)
        {
            chapterOne(1);
        }
        else if (storyPoint == 21) //meet the general
        {
            if (x == 1) //Don't care
            {
                chapterOne(11);
            }
            else if (x == 2) //Explain yourself
            {
                chapterOne(12);
            }
            else if (x == 3) //Get to the point
            {
                chapterOne(13);
            }
            else if (x == 4) //Say Nothing
            {
                chapterOne(14);
            }
        }
        else if (storyPoint == 22) // repplied to the guard
        {
            if (x == 2)
            {
                chapterOne(15); // Continue
            }
        }
        else if (storyPoint == 23) // DO THE TUTORIAL?
        {
            if (x == 1) //Yes
            {
                chapterOne(16); //Tutorial
            }
            else if (x == 2) //No
            {
                chapterOne(17); // BREIF
            }
        }
        else if (storyPoint == 24) // TUTotial explained
        {

            if (x == 2)
            {
                chapterOne(17); // Continue
            }
        }
        else if (storyPoint == 25) // Get out of the kingdom
        {
            if (x == 2) 
            {
                chapterOne(18);
            }
        }
        else if (storyPoint == 26) //theif encounter
        {
            if (x == 2) // Go to general store
            {
                saveNarativePoint = 18;
                saveNarativeChapter = 1;
                gc.gameObject.GetComponent<shop>().enter(1);                
            }
            else if (x == 3) //continue
            {
                chapterOne(19);
            }
        }
        else if (storyPoint == 27)
        {
            if (x == 1)
            {
                chapterOne(20); // none of your buisines
            }
            else if (x == 2)
            {
                chapterOne(21); //respond
            }
            else if (x == 3)
            {
                chapterOne(22); //first you then I 
            }
            else if (x == 4) //walk away
            {
            //storyPoint = 29;
            saveNarativePoint = 23;
            gc.gameObject.GetComponent<enemies>().fight(1);  
            }
        }
        else if (storyPoint == 28) //fight theif
        {
            if (x == 2)
            {
                //storyPoint = 29;
                saveNarativePoint = 23;
                gc.gameObject.GetComponent<enemies>().fight(1);
            }
        }
        if (storyPoint == 29) // killed the theif
        {
            if (x == 2)
            {
                chapterOne(24);
            }
        }
        else if (storyPoint == 30) // meet billy
        {
            if (x == 2)
            {
                chapterOne(241); //help him
            }
            else if (x == 3)
            {
                chapterOne(242); //move along 
            }
            else if (x == 4)
            {
                chapterOne(243); //steel his stuff
            }
        }
        else if (storyPoint == 31)
        {
            if (x == 2)
            {
                chapterOne(2411); // refuse gift
            }
            else if (x == 3)
            {
                chapterOne(2412); // accept gift
            }
        }
        else if (storyPoint == 32)
        {
            if (x == 2)
            {
                chapterOne(25); // continue
            }
        }
        else if (storyPoint == 33) // procede to chaptertwo
        {
            if (x == 2)
            {
                ChapterTwo(1); // go to tavern
            }
            if (x == 3)
            {
                ChapterTwo(2); // go to forest
            }
        }

        else if (storyPoint == 34)
        {
            if (x == 1)
            {
                ChapterTwo(11); //talk to the people
            }
            else if (x == 2)
            {
                ChapterTwo(12); //inside the tavern
            }
            else if (x == 3)
            {
                ChapterTwo(13); //Analyse the area
            }
            else if (x == 4)
            {
                ChapterTwo(2); //go to forest
            }
        }
        else if (storyPoint == 341) //tak to the people
        {

            if (x == 2)
            {
                ChapterTwo(111); //help
            }
            else if (x == 3)
            {
                ChapterTwo(112); //refuse politely
            }
            else if (x == 4)
            {
                ChapterTwo(113); //refuse
            }
        }
        else if (storyPoint == 342) // after speaking with the people
        {
            if (x == 2)
            {
                ChapterTwo(12); // go in the tavern
            }
            else if (x == 3)
            {
                ChapterTwo(2); //head towards the forest
            }
        }
        else if (storyPoint == 343) // in the tavern
        {
            if (x == 2)
            {
                ChapterTwo(121); // see what the fuss is about
            }
            else if (x == 3)
            {
                ChapterTwo(122); // talk to the bartender
            }
        }
        else if (storyPoint == 344) // you know Kail
        {
            if (x == 2)
            {
                ChapterTwo(1211); // ask about Pik
            }
            else if (x == 3)
            {
                ChapterTwo(122); // talk to the bartender
            }
        }
        else if (storyPoint == 345) // you asked about Pik
        {
            if (x == 2)
            {
                ChapterTwo(1211); // let him finish
            }
            else if (x == 3)
            {
                ChapterTwo(1213); // get to the point
            }
        }
        else if (storyPoint == 346)//going to the forest
        {
            if (x == 2)
            {
                ChapterTwo(1); // back to tavern
            }
            else if (x == 3)
            {
                ChapterTwo(2); //head in
            }
        }
        else if (storyPoint == 3451) // found shortcut
        {
            if (x == 3)
            {
                ChapterTwo(122); // go to 
            }
        }
        else if (storyPoint == 3452) // go to forest
        {
            if (x == 3)
            {
                ChapterTwo(2); // go to the forest
            }
        }
        else if (storyPoint == 351)
        {
            if (x == 2)
            {
                ChapterTwo(21);
            }
        }
        else if (storyPoint == 352)
        {
            if (x == 2)
            {
                storyPoint = 3521;
                saveNarativePoint = 211;
                gc.gameObject.GetComponent<enemies>().fight(2);
            }
        }
        else if (storyPoint == 3521)
        {
            if (x == 2)
            {
                ChapterTwo(22);
            }
        }
        else if (storyPoint == 3531) // continue into the woods
        {
            if (x == 2)
            {
                ChapterTwo(221); //attack him
            }
            else if (x == 3)
            {
                ChapterTwo(222); //say you kno about him
            }
            else if (x == 4)
            {
                ChapterTwo(223); //Withold information
            }
        }
        else if (storyPoint == 3532)
        {
            if (x == 2)
            {
                ChapterTwo(224); //tell him everything
            }
            else if (x == 3)
            {
                ChapterTwo(225); //hunch about who he is
            }
            else if (x == 4)
            {
                ChapterTwo(226); // continue walking
            }
        }
        else if (storyPoint == 41)
        {
            gc.gameObject.GetComponent<MainMenu>().WinGame(3);
        }
    }


}
