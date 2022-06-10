using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureSys : MonoBehaviour
{
    public BoxCollider box;
    public float Height;
    public LayerMask AlfieMask;

    
    void FixedUpdate()
    {
        if(isHit()){
            Debug.Log("alfie hit");
        }
    }

    private bool isHit(){
        return Physics2D.BoxCast(box.bounds.center, box.bounds.size, 0f, Vector2.down, Height, AlfieMask);
    }
}
