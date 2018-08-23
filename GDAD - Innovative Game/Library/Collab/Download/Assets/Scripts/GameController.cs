using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    public GameObject gc;
    public GameObject defeatedScreen;
    public GameObject winScreen;
    public GameObject lastHit;  //image
    // +++++++++++++++ GAME OBJECTS +++++++++++++++
    public GameObject player;
    public Transform playerSpawn;

    public GameObject enemyType1;
    public GameObject enemyType2;
    public GameObject enemyType3;
    public GameObject enemyType4;
    public GameObject enemyType5;

    public GameObject asteroid;

    public GameObject powerUpwpnLVL;
    public GameObject powerUpDMG;
    public GameObject powerUpSPEED;

    public GameObject GpowerUpwpnLVL;
    public GameObject GpowerUpDMG;
    public GameObject GpowerUpSPEED;
    // +++++++++++++++ END GAME OBJECTS +++++++++++++++

	public float maxMultiplier;
	public float multiplierIncrease = 0.1f;
	public float multiplierTime = 1f;

	public int minimumDifficulty = 100;
    private static int points;
	public List<GameObject> enemyShips;
	private static int round = 1;

    private bool roundIsGoing; // keeps track if round is still going 
    private bool enoughEnemies = false; // this checks if there are too many enemies on screen
    private bool enoughAsteroids = false;    // this checks if there are too many asteroids on screen

    public int XMax;
    public int YMax;

	// Use this for initialization
	void Start ()
	{
        this.GetComponent<UIManager>().levelUpdate(round / 10, round % 10);
        if(gc.gameObject.GetComponent<SceneController>().returnSceneSaver() == 1)
        {
            InvokeRepeating("increaseMultiplier", 3f, multiplierTime);
            this.enemyShips = calculateEnemies(points);
        }
		Time.timeScale = 1f;
	}

    public void spawnPowerUp(Transform location)
    {
        int x = Random.Range(0, 200);
        if (x == 1)
        {
            Instantiate(powerUpwpnLVL, location.position, location.rotation);
        }
        else if(x == 49)
        {
            Instantiate(powerUpDMG, location.position, location.rotation);
        }
        else if (x == 99)
        {
            Instantiate(powerUpSPEED, location.position, location.rotation);
        }
        else if (x == 120)
        {
            Instantiate(GpowerUpwpnLVL, location.position, location.rotation);
        }
        else if (x == 150)
        {
            Instantiate(GpowerUpDMG, location.position, location.rotation);
        }
        else if (x == 199)
        {
            Instantiate(GpowerUpSPEED, location.position, location.rotation);
        }
    }

    // Update is called once per frame
    void Update ()
	{
        if(roundIsGoing)
        {
            if (!enoughAsteroids) spawnAsteroids(); // IF ENOUGH ASTEROIDS THEN STOP SPAWNING 
			if (!enoughEnemies && enemyShips.Count != 0 && spawnEnemy (enemyShips [0])) {
				enemyShips.RemoveAt (0);
			} else if (enemyShips.Count == 0) {
				pointsFinished = true;
			}
            checkEndRoundCond();
            checkNoOfAsteroids();
            checkNoOfEnemies();
            if(Time.timeScale <= 1) { lastHit.gameObject.SetActive(true); } else { lastHit.gameObject.SetActive(false); }
            endGame();
        }
	}

	void increaseMultiplier()
	{
        if(Time.timeScale == 1 - multiplierIncrease)
        {
            lastHit.gameObject.SetActive(false);
        }

        if (Time.timeScale < maxMultiplier) {
			Time.timeScale += multiplierIncrease;
			gc.gameObject.GetComponent<UIManager>().setMulti(Time.timeScale);
		}

        
	}

	void setMultiplier(float f) {
		Time.timeScale = f;
	}

    public void startRound()
    {
        roundIsGoing = true;
    }

    public void spawnPlayer()
    {
        Instantiate(player, playerSpawn.position, playerSpawn.rotation);
    }

    private float spawnEnemyTimer = 3f;
    private float ETimer = 0f;
	public bool spawnEnemy(GameObject ship)
	{
		ETimer -= Time.deltaTime;
		if (ETimer <= 0f && !pointsFinished)
		{
			ETimer = spawnEnemyTimer;
			// SPAWN LOCATION
			int x = Random.Range(0, 4) + 1;
			Vector3 spawnPosition;
			Quaternion spawnRotation = Quaternion.identity;
			if (x == 1)//North
			{
				spawnPosition = new Vector3(Random.Range(-XMax, XMax + 1), YMax, 0f);
			}
			else if (x == 2) //South 
			{
				spawnPosition = new Vector3(Random.Range(-XMax, XMax + 1), -YMax, 0f);
			}
			else if (x == 3) //East
			{
				spawnPosition = new Vector3(XMax, Random.Range(-YMax, YMax + 1), 0f);
			}
			else   //West
			{
				spawnPosition = new Vector3(-XMax, Random.Range(-YMax, YMax + 1), 0f);
			}
			//INSTANTIATE ENEMY 
			Instantiate(ship, spawnPosition, spawnRotation);
			return true;
		}
		return false;
	}


    private float spawnAsteroidTimer = 3f; // SETS TIME BETWEEN ASTEROID SPAWN
    private float ATimer = 0f;
    public void spawnAsteroids()
    {
        ATimer -= Time.deltaTime;
        if (ATimer <= 0f)
        {
            ATimer = spawnAsteroidTimer;
            int x = Random.Range(0, 4) + 1;
            Vector3 spawnPosition;
            Quaternion spawnRotation;
            if (x == 1)//North
            {
                spawnPosition = new Vector3(Random.Range(-XMax - 1, XMax + 2), YMax + 1, 0f);
                spawnRotation = Quaternion.Euler(0, 0, -90);
            }
            else if (x == 2) //South 
            {
                spawnPosition = new Vector3(Random.Range(-XMax - 1, XMax + 2), -YMax - 1, 0f);
                spawnRotation = Quaternion.Euler(0, 0, 90);
            }
            else if (x == 3) //East
            {
                spawnPosition = new Vector3(XMax + 1, Random.Range(-YMax - 1, YMax + 2), 0f);
                spawnRotation = Quaternion.Euler(0, 0, 180);
            }
            else   //West
            {
                spawnPosition = new Vector3(-XMax - 1, Random.Range(-YMax - 1, YMax + 2), 0f);
                spawnRotation = Quaternion.Euler(0, 0, 0);
            }
            Instantiate(asteroid, spawnPosition, spawnRotation);
        }
    }

    public void addPoints(int x)
    {
        points += x ;
        gc.gameObject.GetComponent<UIManager>().setScore(points);
    }

    public void hit()
    {
		Debug.Log("Player got shot! Current multiplier " + Time.timeScale);
		if (Time.timeScale > 2)
		{
			this.setMultiplier (Time.timeScale / 2);
		}
		else if (Time.timeScale > 1)
        {
            this.setMultiplier(1f);
        }
		else if (Time.timeScale >= 1)
        {
            this.setMultiplier(0.5f);
        }
        else
        {
            this.setMultiplier(0f);
        }
    }

    // ++++++++++++++++++++++ GAME CHECKERS +++++++++++++++++++++++
    private GameObject[] getAsteroidsCount;
    private GameObject[] getEnemiesCount;
    int asteroidCount;
    bool pointsFinished = false; 
    int enemiesCount;

    public void checkNoOfAsteroids()
    {
        getAsteroidsCount = GameObject.FindGameObjectsWithTag("obstacle");
        asteroidCount = getAsteroidsCount.Length;
        if (asteroidCount >= 5) enoughAsteroids = true;
        else enoughAsteroids = false;
    }

    public void checkNoOfEnemies()
    {
        getEnemiesCount = GameObject.FindGameObjectsWithTag("enemy");
        enemiesCount = getEnemiesCount.Length;
        if (enemiesCount >= 15) enoughEnemies = true;
        else enoughEnemies = false;
    }

    private float dontPopInstantTimer = 3f;
    public void checkEndRoundCond()
    {
        if(pointsFinished && enemiesCount == 0)
        {
            dontPopInstantTimer -= Time.deltaTime;
            if (dontPopInstantTimer <= 0f)
            {
                dontPopInstantTimer = 3f;
                roundIsGoing = false;
				round += 1;
                gc.GetComponent<UIManager>().setCDown(false);
                winScreen.gameObject.SetActive(true);
                // set new score for enemy spawn calculator
                calculateCredits();
            }
        }
    }

    // +++++++++++++++++++++++++++++ END GAME & NEXT WAVE ++++++++++++++++++++++++++++++++

    public void endGame()
    {
        if(Time.timeScale <= 0.25)
        {
            lastHit.gameObject.SetActive(false);
            roundIsGoing = false;
            defeatedScreen.gameObject.SetActive(true);
            gc.gameObject.GetComponent<LeaderboardUI>().saveScore(gc.gameObject.GetComponent<UIManager>().returnScore()); // adds the player to the leaderboard if score is big enough
            gc.gameObject.GetComponent<LeaderboardUI>().finishGame();
        }
    }

    public void nextWave()
    {
        roundIsGoing = true;
        pointsFinished = false;
        calculateNewRoundPoints();
        gc.gameObject.GetComponent<UIManager>().timeTrack = 4f;
    }


    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //+++++++++++++++++++++++++++++++++++ CALCULATING ENEMIES TO SPAWN +++++++++++++++++++++++++++++
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    int toSpawn;

	private List<GameObject> calculateEnemies(int maxPoints)
	{
		List<GameObject> enemyShips = new List<GameObject> ();
		enemyShips.Add (enemyType1);
		if (round >= 2) {enemyShips.Add (enemyType2);};
		if (round >= 3) {enemyShips.Add (enemyType3);};
		if (round >= 4) {enemyShips.Add (enemyType4);};
		if (round >= 5) {enemyShips.Add (enemyType5);};

		System.Random rand = new System.Random ();
		List<GameObject> ships = new List<GameObject>();
		int currentPoints = 0;
		if (maxPoints < minimumDifficulty) {maxPoints = minimumDifficulty;}
		while (currentPoints < maxPoints)
		{
			GameObject ship = enemyShips [rand.Next (enemyShips.Count)];
			ships.Add (ship);
			currentPoints += ship.GetComponent<EnemyController> ().pointsToGive;
		}
		return ships;
	}

    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //+++++++++++++++++++++++++++++++++++ CALCULATING NEW ROUND POINTS +++++++++++++++++++++++++++++
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    public void calculateNewRoundPoints()
    {
        calculateCredits();
    }

    float lastRoundPoints;
    float thisToundPoints;

    public void calculateCredits()
    {
        gc.gameObject.GetComponent<ShopUIManager>().setCredits(points/20); 
    }

	public static int getRound() {
		return round;
	}
}
