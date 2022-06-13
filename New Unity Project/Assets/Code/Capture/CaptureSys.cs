using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureSys : MonoBehaviour
{
    public LayerMask layerMask;
    float timetoTick = .2f;
    float tickrate = .2f;

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


        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
        }
    }

    void OnDrawGizmos(){
        Gizmos.color = test;
        //Gizmos.DrawWireSphere(transform.position, maxDis);
        //Gizmos.DrawRay(transform.position, Vector3.forward, maxDis);
    } 
}
