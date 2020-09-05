using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Takip : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform hedef;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        agent.destination = hedef.position;
    }
}
