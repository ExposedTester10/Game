using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    // Add your best times here
    /*
    1 2:30
    2 2:12
    3
    4
    5
    6
    7
    8
    9
    10
    11
    12
    13
    14
    15
    16
    17
    18
    19
    20
    */
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI savedPeopleText;
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject win;
    [SerializeField] GameObject loose;
    [SerializeField] GameObject tutorialText;
    bool stopTimer = false;
    float timer;
    [SerializeField] float startTimer;
    [SerializeField] int winCondition;
    [SerializeField] PlayerFOV playerFOVScript;
    [SerializeField] GameObject playerFOV;
    [SerializeField] GameObject player;
       void Start()
    {
        timer = startTimer;
        // timer = 1;
        playerFOVScript = playerFOV.GetComponent<PlayerFOV>();
        win.SetActive(false);
        loose.SetActive(false);
        tutorialText.SetActive(true);
    }

    void Update()
    {
        if(timer > 0 && !stopTimer)
        {
            timer -= Time.deltaTime;
        } else if(timer <= 0)
        {
            timer = 0;
            Loose();
        }
        if(playerFOVScript.Score >= winCondition)
        {
            Win();
        }

        if(timer <= 135)
        {
            tutorialText.SetActive(false);
        }
        
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        moneyText.text = playerFOVScript.money.ToString();
        scoreText.text = playerFOVScript.Score.ToString();
    }

    void Loose()
    {
        player.SetActive(false);
        loose.SetActive(true);
    }
    void Win()
    {
        player.SetActive(false);
        win.SetActive(true);
        stopTimer = true;
    }
}
