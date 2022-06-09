using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeCheck : MonoBehaviour
{
    

    void Update()
    {
        SlopeNav();
    }

    void SlopeNav(){
        //RaycastHit hit;

        Debug.DrawRay(transform.position, Vector3.forward, Color.cyan, 2f);
    }
}
