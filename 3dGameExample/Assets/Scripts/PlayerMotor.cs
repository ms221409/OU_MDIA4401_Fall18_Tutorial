using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;	// STEP 7


public class PlayerMotor : MonoBehaviour 
{
	private Vector3 _currentTarget;

	// STEP 7
	public NavMeshAgent agent;
	

	void Update ()
	{
		//
		if (Input.GetMouseButton (0))
		{
			// Raycast to ground
			RaycastHit hit;
        	Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) 
			{
				_currentTarget = hit.point;
			}
		}


		// STEP 1:
		// transform.position = Vector3.MoveTowards (transform.position, _currentTarget, Time.deltaTime * 5);

		// (fix player origin / raycast Y compensator)

		// STEP 2:
		//_currentTarget = new Vector3 (_currentTarget.x, transform.position.y, _currentTarget.z);
		//transform.position = Vector3.MoveTowards (transform.position, _currentTarget, Time.deltaTime * 5);

		// STEP 3:
		// _currentTarget = new Vector3 (_currentTarget.x, transform.position.y, _currentTarget.z);
		// transform.LookAt (_currentTarget);

		// STEP 4:
		// _currentTarget = new Vector3 (_currentTarget.x, transform.position.y, _currentTarget.z);
		// transform.LookAt (_currentTarget);
		// transform.Translate (Vector3.forward * Time.deltaTime * 3);

		// STEP 5:
		// _currentTarget = new Vector3 (_currentTarget.x, transform.position.y, _currentTarget.z);
		// float distanceToTarget = Vector3.Distance (transform.position, _currentTarget);
		// if (distanceToTarget > 0.5f)
		// {
		// 	transform.LookAt (_currentTarget);
		// 	transform.Translate (Vector3.forward * Time.deltaTime * 3);
		// }

		// STEP 6:
		//  _currentTarget = new Vector3 (_currentTarget.x, transform.position.y, _currentTarget.z);
		//  float distanceToTarget = Vector3.Distance (transform.position, _currentTarget);
		// if (distanceToTarget > 0.5f)
		// {
		// 	Vector3 targetDir = _currentTarget - transform.position;
		// 	Quaternion lookRotation = Quaternion.LookRotation (targetDir);
		// 	transform.rotation = Quaternion.Slerp (transform.rotation, lookRotation, Time.deltaTime * 10);
			
		// 	transform.Translate (Vector3.forward * Time.deltaTime * 3);
		// }

		// STEP 7
		float distanceToTarget = Vector3.Distance (transform.position, _currentTarget);
		if (distanceToTarget > 0.5f)
		{
			agent.SetDestination (_currentTarget);
		}
	}
}
