using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavGizmos : MonoBehaviour
{
    public float waypointSize = 1f;
    public Color LineColour;
    public Color SphereColour;

    private void OnDrawGizmos(){
        foreach(Transform t in transform){
            Gizmos.color = SphereColour;
            Gizmos.DrawWireSphere(t.position, waypointSize);
        }

        Gizmos.color = LineColour;
        for(int i = 0; i < transform.childCount -1; i++){
            Gizmos.DrawLine(transform.GetChild(i).position, transform.GetChild(i + 1).position);
        }
    }
}
