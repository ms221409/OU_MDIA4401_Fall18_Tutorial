using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;   // Necessary for NavMesh


public class EnemyMotor : MonoBehaviour 
{
    public NavMeshAgent agent;
    public Transform navTarget;

	
	// Update is called once per frame
	void Update () 
    {
        agent.SetDestination (navTarget.position);
	}
}
