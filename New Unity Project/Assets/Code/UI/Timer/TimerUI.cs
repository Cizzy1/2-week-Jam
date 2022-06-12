using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    //Timer
    public Text timertext;
    public float timeRemaining;
    public Animator FlashingRed;
    bool TimerIsRunning = false;
    float TimeLapsed;

    //Screens
    [Header("Alfie Fail Screen")]
    public GameObject FailScreen;

    //Text
    [Header("Pete Win text")]
    public Text timeIn;
    //public Text TotalEarn;
/* 
    //Transforms
    public Transform Player;
    public Transform ExitDoor;
    public GameObject FinishedTab;
    int MinDis = 1;


    //Values
    int cashCount; */

    void Awake()
    {
        TimerIsRunning = true;
        Time.timeScale = 1f;

        TimeLapsed = Time.timeSinceLevelLoad;
        FlashingRed.SetBool("NearlyOut", false);
    }

    void Update()
    {
        //is time true
        if(TimerIsRunning){
            
        } else{
            return;
        }
/* 
        //Bank Leave 
        //cashCount = Player.GetComponent<MoneySystem>().scoreVal;
        if(cashCount > 650000 && Vector2.Distance(ExitDoor.position, Player.position) <= MinDis){
            Time.timeScale = 0f;
            FinishedTab.SetActive(true);
            timeIn.text = "Time : " + TimeLapsed;
            TotalEarn.text = "Total : " + cashCount;
        } */

        //Warning
        if(timeRemaining <= 25){
            TimeReminder();
        }

        //Out of time
        if(timeRemaining > 0){
            timeRemaining -= Time.deltaTime;
            DisplayTimer(timeRemaining);
        } else {
            TimerEnd();
        }
        TimeLapsed = Time.timeSinceLevelLoad;
    }
    
    //Where the magic happens
    void DisplayTimer(float timeToDisplay){
        //Adds one every second
        timeToDisplay += 1;
        //Interp between 0 - 1
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        //Uses string format and updates timer at top of screen
        timertext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void TimeReminder(){
        //Waring text
        //timertext.color = Color.red;
        FlashingRed.SetBool("NearlyOut", true);
    }

    void TimerEnd(){
        if(timeRemaining < 0){
            //out of time screen.
            timeRemaining = 0;
            TimerIsRunning = false;
            timertext.text = ("OUT OF TIME");   
            FailScreen.SetActive(true);
        }
    }
}
