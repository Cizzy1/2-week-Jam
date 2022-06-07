using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AINav : MonoBehaviour
{
    NavMeshAgent myAI;
    public Transform [] Waypoints;

    void Awake(){
        myAI = GetComponent<NavMeshAgent>();
    }

    void Start(){
        myAI.SetDestination(Waypoints[0].position);
    }

    void Update(){
        if(myAI.remainingDistance <= .25f){
            for(int i = 0; i < Waypoints.Length; i++){
                myAI.SetDestination(Waypoints[i].position);
                Debug.Log("Current point " + Waypoints[i].name.ToString());
            }
            //NextPoint();
        }

        Debug.Log(myAI.destination.ToString());

        if(myAI.destination == null){
            myAI.SetDestination(Waypoints[0].position);
        }
        
    }

    /* void NextPoint(){
        for(int i = 0; i < Waypoints.Length; i++){
            myAI.SetDestination(Waypoints[i].position);
            Debug.Log("Current point " + Waypoints[i].name.ToString());
        }
    } */

    /* void PickerPoint(){
        int randomPicker;
        randomPicker = Random.Range(0, Waypoints.Length);
        
        myAI.SetDestination(Waypoints[randomPicker].position);
    } */
}
