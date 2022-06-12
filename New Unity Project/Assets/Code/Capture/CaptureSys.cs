using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureSys : MonoBehaviour
{
    public LayerMask AlfieMask;
    float timetoTick = .2f;
    float tickrate = .2f;

    public Color test;

    RaycastHit hit;
    public float maxDis;
    bool isHit;

    
    void Update()
    {
        isHit = Physics.SphereCast(transform.position, maxDis, Vector3.forward, out hit, AlfieMask);

        if(isHit && Time.time > timetoTick){
            timetoTick = Time.time + tickrate;
            Debug.Log("alfie hit");
            Debug.Log(hit.collider.name);
            Debug.Log(hit.collider.gameObject.layer);
        }
    }

    /* void OnDrawGizmos(){
        Gizmos.color = test;
        Gizmos.DrawWireSphere(transform.position, maxDis);
    } */
}
