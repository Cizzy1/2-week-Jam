using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AINav : MonoBehaviour
{

    public UnityEngine.AI.NavMeshAgent agent;
    public GameObject NPC;
    public float speed = 2f;
    public float rotSpeed = 1f;
    public float accuracy = 3f;

    /* public override void OnStateEnter(){
        opponent = NPC.GetComponent<TestAI>().GetPlayer();
        agent = NPC.GetComponent<UnityEngine.AI.NavMeshAgent>();
    } */
}
