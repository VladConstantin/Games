using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using System;

public class LeaderboardUI : MonoBehaviour {

    public InputField Name;

    private static SortedDictionary<int, string> scores = new SortedDictionary<int, string>();


    public Text no1;
    public Text no1Points;

    public Text no2;
    public Text no2Points;

    public Text no3;
    public Text no3Points;

    public Text no4;
    public Text no4Points;

    public Text no5;
    public Text no5Points;

    bool lost = false;
    public string n;
    private static bool restart = true;

    public void finishGame()
    {
        lost = true;
    }

    void Start()
    {
        if (restart)
        {
            scores.Add(1000000, "AAA");
            scores.Add(100000, "BBB");
            scores.Add(10000, "CCC");
            scores.Add(1000, "DDD");
            scores.Add(100, "EEE");
            scores.Add(10, "FFF");
            restart = false;
        }
    }

    void Update()
    {
        if(lost)
        {
            n = Name.text;
        }
    }

    int score = 0;
    public void saveScore(float s)
    {
        score = (int)s;
    }

    public void fixLderbrd()
    {
        scores.Add(score, n);
        int x = scores.Count;
    }

    public void loadLrdbrd()
    {
        int x = scores.Count;

        foreach (KeyValuePair <int,string> s in scores)
        {

            if (x == 1)
            {
                no1.text = s.Value;
                no1Points.text = ""+s.Key;
            }
            else if (x == 2)
            {
                no2.text = s.Value;
                no2Points.text = "" + s.Key;
            }
            else if (x == 3)
            {
                no3.text = s.Value;
                no3Points.text = "" + s.Key;
            }
            else if (x == 4)
            {
                no4.text = s.Value;
                no4Points.text = "" + s.Key;
            }
            else if (x == 5)
            {
                no5.text = s.Value;
                no5Points.text = "" + s.Key;
            }
            x--;
        }
    }
}
