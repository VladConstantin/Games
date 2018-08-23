﻿using UnityEngine.UI;
    public Image shipBtn3;
    public Text shipTxt2;
    public Text shipTxt3;
    // ++++++++++++++++++++ END SHIP SKIN STUFF +++++++++++++++++++

    // ++++++++++++++++++++ BLUE SETUP +++++++++++++++++++++++
    public Image blueLVL2;
    // ++++++++++++++++++++ END GREEN SETUP +++++++++++++++++++++++

    // ++++++++++++++++++++ DISPLAY CREDITS SETUP +++++++++++++++++++++++
    public Text creditsWallet;

    public Text creditsCostBdmg;
    public Text creditsCostBspeed;
    public Text creditsCostBlvl;

    public Text creditsCostGdmg;
    public Text creditsCostGspeed;
    public Text creditsCostGlvl;
    // ++++++++++++++++++++ END DISPLAY CREDITS SETUP +++++++++++++++++++++++
    private static int credits;

    // set ammount of credits in order to get lvl up from shop
    private static int blPrice = 12; //lvl

    private static int glPrice = 12;
    private static int gdPrice = 6;
    private static int gsPrice = 6;

    // ++++++++++++++++++++ BLUE CONTAINER SET UP +++++++++++++++++++++++

    void Start()
    {
        if(gc.gameObject.GetComponent<SceneController>().returnSceneSaver() == 2)
        {
            updateShopUI();
            updateWallet();
            shipSkin(memoriseShip);
        }
    }
            updateWallet();
        }
            updateWallet();
            updateWallet();
    // ++++++++++++++++++++ END BLUE CONTAINER SET UP +++++++++++++++++++++++

    // ++++++++++++++++++++ GREEN CONTAINER SET UP +++++++++++++++++++++++
    public void gUpgradeLVL()
            updateWallet();
        }
            updateWallet();
            Vector3 spawnPosition = new Vector3(greenDmgImgTR.position.x + dist * (gDmg - 1), greenDmgImgTR.position.y, 0);
            updateWallet();
            Vector3 spawnPosition = new Vector3(greenSpeedTR.position.x + dist * (gSpeed - 1), greenSpeedTR.position.y, 0);
    // ++++++++++++++++++++ END GREEN CONTAINER SET UP +++++++++++++++++++++++


    //+++++++++++++++++++++++++++++ UPDATE SECTION +++++++++++++++++++++++++++++++++
    public void updateShopUI()

        // BLUE AREA SETUP
        if (bLvl == 2)
        {
            blueLVL2.gameObject.SetActive(true);
        }
        else if (bLvl == 3)
        {
            blueLVL2.gameObject.SetActive(true);
            blueLVL3.gameObject.SetActive(true);
        }
        else if (bLvl == 4)
        {
            blueLVL2.gameObject.SetActive(true);
            blueLVL3.gameObject.SetActive(true);
            blueLVL4.gameObject.SetActive(true);
        }

        //GREEN AREA SET UP

        if (gLvl == 2)
        {
            greenLVL2.gameObject.SetActive(true);
        }
        else if (gLvl == 3)
        {
            greenLVL2.gameObject.SetActive(true);
            greenLVL3.gameObject.SetActive(true);
        }
        else if (gLvl == 4)
        {
            greenLVL2.gameObject.SetActive(true);
            greenLVL3.gameObject.SetActive(true);
            greenLVL4.gameObject.SetActive(true);
        }
        {
        {

    public void updateWallet()
    {
        creditsWallet.text = "" + credits;

        creditsCostBdmg.text = "" + bdPrice;
        creditsCostBspeed.text = "" + bsPrice;
        creditsCostBlvl.text = "" + blPrice;

        creditsCostGdmg.text = "" + gdPrice;
        creditsCostGspeed.text = "" + gsPrice;
        creditsCostGlvl.text = "" + glPrice;
    }

    //++++++++++++++++++++++++++ SET METHODS +++++++++++++++++++++++++++
    public void setCredits(int x)
    {
        credits += x;
    }
    {
        credits = 0;
    }
    {
        credits += 50;
        updateWallet();
    }

    //++++++++++++++++++++++++++++++SKIN STUFF +++++++++++++++++++++++++
    private int ship2Cost = 30;
    {

        if(i==2 && !purchasedShip2 && credits >= ship2Cost)
        {
            purchasedShip2 = true;
            credits -= ship2Cost;
        }

        if(i==3 && !purchasedShip3 && credits >= ship3Cost)
        {
            purchasedShip3 = true;
            credits -= ship3Cost;
        }

        if(i == 1)
        {
            shipBtn1.GetComponent<Image>().color = new Color32(0, 225, 0, 225);
            shipBtn2.GetComponent<Image>().color = new Color32(225, 225, 225, 225);
            shipBtn3.GetComponent<Image>().color = new Color32(225, 225, 225, 225);
            memoriseShip = i;
        }
        else if(i == 2 && purchasedShip2)
        {
            shipBtn1.GetComponent<Image>().color = new Color32(225, 225, 225, 225);
            shipBtn2.GetComponent<Image>().color = new Color32(0, 225, 0, 225);
            shipBtn3.GetComponent<Image>().color = new Color32(225, 225, 225, 225);
            memoriseShip = i;
        }
        else if(i == 3 && purchasedShip3)
        {
            shipBtn1.GetComponent<Image>().color = new Color32(225, 225, 225, 225);
            shipBtn2.GetComponent<Image>().color = new Color32(225, 225, 225, 225);
            shipBtn3.GetComponent<Image>().color = new Color32(0, 225, 0, 225);
            memoriseShip = i;
        }

        if (purchasedShip2)
        {
            shipTxt2.text = "OWNED";
        }

        if (purchasedShip3)
        {
            shipTxt3.text = "OWNED";
        }
    }

    //+++++++++++++++++++++++++++++ RETURN FUNCTIONS ++++++++++++++++++++++++++++
    public int returnShipSkin()
    {
        return memoriseShip;
    }
    {
        return bLvl;
    }
    {
        return bDmg;
    }
    {
        return bSpeed;
    }

    public int returnGlzrLVL()
    {
        return gLvl;
    }
    {
        return gDmg;
    }
    {
        return gSpeed;
    }

    //+++++++++++++++++++++++++++++ SET FUNCTIONS ++++++++++++++++++++++++++++
    {
        if(bLvl <= 4)
        {
            bLvl += 1;
            blPrice += 18;
        }
    }
    {
        if(bDmg <= 10)
        {
            bDmg += 1;
            bdPrice += 6;
        }
    }
    {
        if(bSpeed <= 10)
        {
            bSpeed += 1;
            bsPrice += 6;
        }
    }

    public void foundGlzrLVL()
    {
        if(gLvl <= 4)
        {
            gLvl += 1;
            glPrice += 18;
        }
    }
    {
        if(gDmg <= 10)
        {
            gDmg += 1;
            gdPrice += 6;
        }
    }
    {
        if(gSpeed <= 10)
        {
            gSpeed += 1;
            gsPrice += 6;
        }
    }

    //+++++++++++++++++++++++++++++ PLAYER DIED FUNCTIONS ++++++++++++++++++++++++++++

    public void playerDied()
    {
        bLvl = 1;
        blPrice = 10;

        bDmg = 1;
        bdPrice = 5;

        bSpeed = 1;
        bsPrice = 5;

        gLvl = 1;
        glPrice = 10;

        gDmg = 1;
        gdPrice = 5;

        gSpeed = 1;
        gsPrice = 5;
        resetCredits();
    }
}