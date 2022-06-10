using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timers : MonoBehaviour
{
    public Image healthBar;

    float TimeCapture, maxTimeCapture = 10;


    private void Start(){
        TimeCapture = maxTimeCapture;
    }

    private void Update(){
        TimeBarFillAmount();
    }

    private void TimeBarFillAmount(){
        healthBar.fillAmount = TimeCapture / maxTimeCapture;
    }

}
