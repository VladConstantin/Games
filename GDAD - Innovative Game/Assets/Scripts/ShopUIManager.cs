using UnityEngine.UI;using UnityEngine;public class ShopUIManager : MonoBehaviour {    public GameObject gc;     public Canvas canvas;    // ++++++++++++++++++++ SHIP SKIN STUFF +++++++++++++++++++    public Image shipBtn1;    public Image shipBtn2;
    public Image shipBtn3;
    public Text shipTxt2;
    public Text shipTxt3;
    // ++++++++++++++++++++ END SHIP SKIN STUFF +++++++++++++++++++

    // ++++++++++++++++++++ BLUE SETUP +++++++++++++++++++++++
    public Image blueLVL2;    public Image blueLVL3;       public Image blueLVL4;    public GameObject blueDmgImgGO;    public Transform blueDmgImgTR;    public GameObject blueSpeedImgGO;    public Transform blueSpeedTR;    // ++++++++++++++++++++ END BLUE SETUP +++++++++++++++++++++++    // ++++++++++++++++++++ GREEN SETUP +++++++++++++++++++++++    public Image greenLVL2;    public Image greenLVL3;    public Image greenLVL4;    public GameObject greenDmgImgGO;    public Transform greenDmgImgTR;    public GameObject greenSpeedImgGO;    public Transform greenSpeedTR;
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
    private static int credits;    private static int bLvl = 1;    private static int bDmg = 1;    private static int bSpeed = 1;    private static int gLvl = 1;    private static int gDmg = 1;    private static int gSpeed = 1;

    // set ammount of credits in order to get lvl up from shop
    private static int blPrice = 12; //lvl    private static int bdPrice = 6; //dmg    private static int bsPrice = 6; //speed

    private static int glPrice = 12;
    private static int gdPrice = 6;
    private static int gsPrice = 6;    private static int dist = 12;

    // ++++++++++++++++++++ BLUE CONTAINER SET UP +++++++++++++++++++++++

    void Start()
    {
        if(gc.gameObject.GetComponent<SceneController>().returnSceneSaver() == 2)
        {
            updateShopUI();
            updateWallet();
            shipSkin(memoriseShip);
        }
    }    public void bUpgradeLVL()    {        if (credits >= blPrice && bLvl < 4)        {            setCredits(-blPrice);            bLvl += 1; blPrice += 18; // we must rethink how to scale the credits 
            updateWallet();            updateShopUI();
        }    }    public void bUpgradeDMG()    {        if (credits >= bdPrice && bDmg < 10)        {            setCredits(-bdPrice);            bDmg += 1; bdPrice += 6; // we must rethink how to scale the credits 
            updateWallet();            Vector3 spawnPosition = new Vector3(blueDmgImgTR.position.x + dist * (bDmg - 1), blueDmgImgTR.position.y, 0);            Quaternion spawnRotation = Quaternion.identity;            GameObject blob = Instantiate(blueDmgImgGO, spawnPosition, spawnRotation);            blob.transform.SetParent(canvas.transform);        }    }    public void bUpgradeSPEED()    {        if (credits >= bsPrice && bSpeed < 10)        {            setCredits(-bsPrice);            bSpeed += 1; bsPrice += 6; // we must rethink how to scale the credits
            updateWallet();            Vector3 spawnPosition = new Vector3(blueSpeedTR.position.x + dist * (bSpeed - 1), blueSpeedTR.position.y, 0);            Quaternion spawnRotation = Quaternion.identity;            GameObject blob = Instantiate(blueSpeedImgGO, spawnPosition, spawnRotation);            blob.transform.SetParent(canvas.transform);        }    }
    // ++++++++++++++++++++ END BLUE CONTAINER SET UP +++++++++++++++++++++++

    // ++++++++++++++++++++ GREEN CONTAINER SET UP +++++++++++++++++++++++
    public void gUpgradeLVL()    {        if (credits >= glPrice && gLvl < 4)        {            setCredits(-glPrice);            gLvl += 1; glPrice += 18; // we must rethink how to scale the credits 
            updateWallet();            updateShopUI();
        }    }    public void gUpgradeDMG()    {        if (credits >= gdPrice && gDmg < 10)        {            setCredits(-gdPrice);            gDmg += 1; gdPrice += 6; // we must rethink how to scale the credits 
            updateWallet();
            Vector3 spawnPosition = new Vector3(greenDmgImgTR.position.x + dist * (gDmg - 1), greenDmgImgTR.position.y, 0);            Quaternion spawnRotation = Quaternion.identity;            GameObject blob = Instantiate(greenDmgImgGO, spawnPosition, spawnRotation);            blob.transform.SetParent(canvas.transform);        }    }    public void gUpgradeSPEED()    {        if (credits >= gsPrice && gSpeed < 10)        {            setCredits(-gsPrice);            gSpeed += 1; gsPrice += 6; // we must rethink how to scale the credits
            updateWallet();
            Vector3 spawnPosition = new Vector3(greenSpeedTR.position.x + dist * (gSpeed - 1), greenSpeedTR.position.y, 0);            Quaternion spawnRotation = Quaternion.identity;            GameObject blob = Instantiate(greenSpeedImgGO, spawnPosition, spawnRotation);            blob.transform.SetParent(canvas.transform);        }    }
    // ++++++++++++++++++++ END GREEN CONTAINER SET UP +++++++++++++++++++++++


    //+++++++++++++++++++++++++++++ UPDATE SECTION +++++++++++++++++++++++++++++++++
    public void updateShopUI()    {

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
        }        for (int i=1; i< bDmg; i++) // blue dmg         {            Vector3 spawnPosition = new Vector3(blueDmgImgTR.position.x + dist * i, blueDmgImgTR.position.y, 0);            Quaternion spawnRotation = Quaternion.identity;            GameObject blob = Instantiate(blueDmgImgGO, spawnPosition, spawnRotation);            blob.transform.SetParent(canvas.transform);        }        for (int i=1; i< bSpeed; i++) // blue speed         {            Vector3 spawnPosition = new Vector3(blueSpeedTR.position.x + dist * i, blueSpeedTR.position.y, 0);            Quaternion spawnRotation = Quaternion.identity;            GameObject blob = Instantiate(blueSpeedImgGO, spawnPosition, spawnRotation);            blob.transform.SetParent(canvas.transform);        }

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
        }        for (int i = 1; i < gDmg; i++) // blue dmg 
        {            Vector3 spawnPosition = new Vector3(greenDmgImgTR.position.x + dist * i, greenDmgImgTR.position.y, 0);            Quaternion spawnRotation = Quaternion.identity;            GameObject blob = Instantiate(greenDmgImgGO, spawnPosition, spawnRotation);            blob.transform.SetParent(canvas.transform);        }        for (int i = 0; i < gSpeed; i++) // blue speed 
        {            Vector3 spawnPosition = new Vector3(greenSpeedTR.position.x + dist * i, greenSpeedTR.position.y, 0);            Quaternion spawnRotation = Quaternion.identity;            GameObject blob = Instantiate(greenSpeedImgGO, spawnPosition, spawnRotation);            blob.transform.SetParent(canvas.transform);        }    }

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
    }    public void resetCredits()
    {
        credits = 0;
    }    public void cheat()
    {
        credits += 50;
        updateWallet();
    }

    //++++++++++++++++++++++++++++++SKIN STUFF +++++++++++++++++++++++++
    private int ship2Cost = 30;    private int ship3Cost = 60;    private static bool purchasedShip2 = false;    private static bool purchasedShip3 = false;    private static int memoriseShip = 1;    public void shipSkin(int i)
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
    }    public int returnBlzrLVL()
    {
        return bLvl;
    }    public int returnBlzrDMG()
    {
        return bDmg;
    }    public int returnBlzrSpeed()
    {
        return bSpeed;
    }

    public int returnGlzrLVL()
    {
        return gLvl;
    }    public int returnGlzrDMG()
    {
        return gDmg;
    }    public int returnGlzrSpeed()
    {
        return gSpeed;
    }

    //+++++++++++++++++++++++++++++ SET FUNCTIONS ++++++++++++++++++++++++++++    public void foundBlzrLVL()
    {
        if(bLvl <= 4)
        {
            bLvl += 1;
            blPrice += 18;
        }
    }    public void foundBlzrDMG()
    {
        if(bDmg <= 10)
        {
            bDmg += 1;
            bdPrice += 6;
        }
    }    public void foundBlzrSpeed()
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
    }    public void foundGlzrDMG()
    {
        if(gDmg <= 10)
        {
            gDmg += 1;
            gdPrice += 6;
        }
    }    public void foundGlzrSpeed()
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