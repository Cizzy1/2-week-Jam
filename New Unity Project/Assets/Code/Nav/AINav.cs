using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AINav : MonoBehaviour
{
    NavMeshAgent myAI;
    public Transform[] Waypoints;
    private int destpoint = 0;

    void Awake(){
        myAI = GetComponent<NavMeshAgent>();
    }

    void Start(){
        myAI.SetDestination(Waypoints[0].position);
        NextPoint();
    }

    void Update(){
        if(myAI.remainingDistance <= .25f){
            NextPoint();
        }

        if(myAI.destination == null){
            myAI.SetDestination(Waypoints[0].position);
        }

        SlopeNav();
    }

    void NextPoint(){
        if(Waypoints.Length == 0){
            return;
        }

        myAI.destination = Waypoints[destpoint].position;

        destpoint = (destpoint + 1) % Waypoints.Length;
    }

///Slope check
//////////////////////////////////
    [Header("Slope Check")]

    public GameObject movingObject;
    public Vector3 originOffset;
    public float maxRayDist = 100f;


    public float slopeRotChangeSpeed = 10f;

    void SlopeNav(){

        Transform objTrans = movingObject.transform;
        Vector3 origin = objTrans.position;

        int hillLayerIndex = LayerMask.NameToLayer("Hill");

        int layerMask = (1 << hillLayerIndex);


        RaycastHit slopeHit;

        if (Physics.Raycast(origin + originOffset, Vector3.down, out slopeHit, maxRayDist, layerMask))
        {
   
        Debug.DrawLine(origin + originOffset, slopeHit.point, Color.red);

      
            Quaternion newRot = Quaternion.FromToRotation(objTrans.up, slopeHit.normal)* objTrans.rotation;


            objTrans.rotation = Quaternion.Lerp(objTrans.rotation, newRot,
            Time.deltaTime * slopeRotChangeSpeed);

        }
    }

}
