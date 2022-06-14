using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptureSys : MonoBehaviour
{
    public LayerMask layerMask;
    float timetoTick = .2f;
    float tickrate = .2f;
    //public Transform pete;
    public Transform alfie;
    public Text distance;
    public GameObject timerUI;
    public Color test;

    RaycastHit hit;
    public float maxDis;
    bool isHit;

    
    void Update()
    {
        /* //isHit = Physics.SphereCast(transform.position, maxDis, Vector3.forward, out hit, CaptureArea);
        isHit = Physics.Raycast(transform.position, Vector3.forward, out hit, maxDis);

        if(hit.collider.tag == "Capture" && Time.time > timetoTick){
            timetoTick = Time.time + tickrate;
            //Debug.Log("alfie hit");
            Debug.Log(hit.collider.name);
            //Debug.Log(hit.collider.gameObject.layer);
        } */

        float dis = Vector3.Distance(transform.position, alfie.position);

        distance.text = dis.ToString("#") + "m";

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, maxDis, layerMask))
        {
            if(Time.time > timetoTick){
                timetoTick = Time.time + tickrate;
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                Debug.Log("Did Hit");
                timerUI.GetComponent<Timers>().Health -= 1f;
            }
        }
    }

    void OnDrawGizmos(){
        Gizmos.color = test;
        //Gizmos.DrawWireSphere(transform.position, maxDis);
        //Gizmos.DrawRay(transform.position, Vector3.forward, maxDis);
    } 
}
