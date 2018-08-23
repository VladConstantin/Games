using UnityEngine.UI;
using System;
using UnityEngine;

public class UIManager : MonoBehaviour {
    // TODO: ADD A SCENE UPDATE ON DEATH BACK TO 0; 
    // TODO: CONNECT SCORE
    // TODO: CONNECT MULTIPLIER
    // TODO: ADD BOTTOM LEFT TYPE OF LASER USED? LASER LEVEL? IDK
    public GameObject gc;

    public Sprite no0;
    public Sprite no1;
    public Sprite no2;
    public Sprite no3;
    public Sprite no4;
    public Sprite no5;
    public Sprite no6;
    public Sprite no7;
    public Sprite no8;
    public Sprite no9;

    public Image MultiNo;
    public Image MultiNo2;
    public Text scoreTxt;
    public Text time;

    private static float score;

    public GameObject countDown;
    public Image cdImg;
    public Image levelNo1st;
    public Image levelNo2nd;
    public Text go;

    private float multi;
    public float timeTrack;
    private bool cwDone;

    private GameObject[] playerSpwnCount;
    int playerCount;

    void Start()
    {
        if (gc.gameObject.GetComponent<SceneController>().returnSceneSaver() == 1)
        {
            timeTrack = 4f;
        }
    }

    void Update()
    {
        this.checkForplayer(); // checks if player is already spawned
        if (gc.gameObject.GetComponent<SceneController>().returnSceneSaver() == 1) //PLAY SCENE
        {
            this.showMulti();
            this.displayScore(score);
            if (cwDone) this.showTime();
            if (timeTrack >= 0f) this.startCount(); // ACTIVATES THE COUNTDOWN TO START WAVES
        }   
    }

    public void checkForplayer()
    {
        playerSpwnCount = GameObject.FindGameObjectsWithTag("Player");
        playerCount = playerSpwnCount.Length;
    }

    public void startCount() // MANAGES COUNT DOWN ON START OF NEW ROUND 
    {
        if (playerCount < 1) gc.gameObject.GetComponent<GameController>().spawnPlayer();
        countDown.gameObject.SetActive(true);
        timeTrack  -= Time.deltaTime;
        cdImg.gameObject.SetActive(true);
        if (timeTrack >= 3f)
        {
            cdImg.GetComponent<Image>().sprite = no3;
        }
        else if(timeTrack >= 2f)
        {
            cdImg.GetComponent<Image>().sprite = no2;
        }
        else if(timeTrack >= 1f)
        {
            cdImg.GetComponent<Image>().sprite = no1;
        }
        else if(timeTrack >= 0f)
        {
            cdImg.gameObject.SetActive(false);
            go.gameObject.SetActive(true);
        }else if(timeTrack <= 0f)
        {
            countDown.gameObject.SetActive(false);
            go.gameObject.SetActive(false);
            cwDone = true; // TURN THIS BACK OFF SOMEWHERE
            gc.gameObject.GetComponent<GameController>().startRound(); //start round in GAME CONTROLER SCRIPT
        }
    }

    public void displayScore(float x) // SCORE DISPLAY
    {
        scoreTxt.text = "" + x;
    }

    float timer;
    public void showTime() // MANAGES THE TIME 
    {
        timer += Time.deltaTime;
        int minutes = Mathf.FloorToInt(timer / 60F);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);
        string niceTime = string.Format("{0:00}:{1:00}", minutes, seconds);

        time.text = niceTime;
    }

    public void showMulti() //MANAGES THE NUMBERS NEXT TO THE MULTIPLYER LABEL IN THE LEFT HAND CORNER
    {
        switch ((int)Math.Floor(multi))
        {
            case 0:
                MultiNo.GetComponent<Image>().sprite = no0;
                break;
            case 1:
                MultiNo.GetComponent<Image>().sprite = no1;
                break;
            case 2:
                MultiNo.GetComponent<Image>().sprite = no2;
                break;
            case 3:
                MultiNo.GetComponent<Image>().sprite = no3;
                break;
            case 4:
                MultiNo.GetComponent<Image>().sprite = no4;
                break;
            case 5:
                MultiNo.GetComponent<Image>().sprite = no5;
                break;
        }

        switch ((int)(10*(multi - Math.Floor(multi))))
        {
            case 0:
                MultiNo2.GetComponent<Image>().sprite = no0;
                break;
            case 1:
                MultiNo2.GetComponent<Image>().sprite = no1;
                break;
            case 2:
                MultiNo2.GetComponent<Image>().sprite = no2;
                break;
            case 3:
                MultiNo2.GetComponent<Image>().sprite = no3;
                break;
            case 4:
                MultiNo2.GetComponent<Image>().sprite = no4;
                break;
            case 5:
                MultiNo2.GetComponent<Image>().sprite = no5;
                break;
            case 6:
                MultiNo2.GetComponent<Image>().sprite = no6;
                break;
            case 7:
                MultiNo2.GetComponent<Image>().sprite = no7;
                break;
            case 8:
                MultiNo2.GetComponent<Image>().sprite = no8;
                break;
            case 9:
                MultiNo2.GetComponent<Image>().sprite = no9;
                break;

        }
    }

    public void levelUpdate(int x, int y) // SHOWS WHAT LEVEL THE PLAYER IS ON X IS THE FIRST DIGIT AND Y IS THE SECOND DIGIT
    {
        switch (x)
        {
            case 0:
                levelNo1st.GetComponent<Image>().sprite = no0;
                break;
            case 1:
                levelNo1st.GetComponent<Image>().sprite = no1;
                break;
            case 2:
                levelNo1st.GetComponent<Image>().sprite = no2;
                break;
            case 3:
                levelNo1st.GetComponent<Image>().sprite = no3;
                break;
            case 4:
                levelNo1st.GetComponent<Image>().sprite = no4;
                break;
            case 5:
                levelNo1st.GetComponent<Image>().sprite = no5;
                break;
            case 6:
                levelNo1st.GetComponent<Image>().sprite = no6;
                break;
            case 7:
                levelNo1st.GetComponent<Image>().sprite = no7;
                break;
            case 8:
                levelNo1st.GetComponent<Image>().sprite = no8;
                break;
            case 9:
                levelNo1st.GetComponent<Image>().sprite = no9;
                break;
        }

        switch (y)
        {
            case 0:
                levelNo2nd.GetComponent<Image>().sprite = no0;
                break;
            case 1:
                levelNo2nd.GetComponent<Image>().sprite = no1;
                break;
            case 2:
                levelNo2nd.GetComponent<Image>().sprite = no2;
                break;
            case 3:
                levelNo2nd.GetComponent<Image>().sprite = no3;
                break;
            case 4:
                levelNo2nd.GetComponent<Image>().sprite = no4;
                break;
            case 5:
                levelNo2nd.GetComponent<Image>().sprite = no5;
                break;
            case 6:
                levelNo2nd.GetComponent<Image>().sprite = no6;
                break;
            case 7:
                levelNo2nd.GetComponent<Image>().sprite = no7;
                break;
            case 8:
                levelNo2nd.GetComponent<Image>().sprite = no8;
                break;
            case 9:
                levelNo2nd.GetComponent<Image>().sprite = no9;
                break;
        }
    }

    // ++++++++++++++++++++++++++++ SET METHODS ++++++++++++++++++++++++++++

    public void setMulti(float x) // MULTIPLIER SET
    {
        multi = x;
    }

    public float returnScore()
    {
        return score;
    }

    public void setCDown(bool x)
    {
        cwDone = x;
    }

    public void setScore(float points)
    {
        score += points;
    }

    public void resetScore()
    {
        score = 0;
    }
}
