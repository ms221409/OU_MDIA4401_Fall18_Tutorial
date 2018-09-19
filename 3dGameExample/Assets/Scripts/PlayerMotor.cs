using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;	// Necessary for NavMesh


public class PlayerMotor : MonoBehaviour 
{
	#region Variables 

		#region Public 

		[Header ("References")]
		public NavMeshAgent agent;

		#endregion

		#region Private

		// The player's current destination - where are we moving towards?
		private Vector3 _currentTarget;

		#endregion

	#endregion
	

	#region Update 

	// Main logic loop
	// Update is called every frame
	void Update ()
	{
		// Listen for mouse down
		if (Input.GetMouseButton (0))
		{
			// Raycast from camera
			RaycastHit hit;
        	Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			// If our raycast hits, store hit point in _currentTarget variable for later use
			if (Physics.Raycast (ray, out hit)) 
			{
				_currentTarget = hit.point;
			}
		}


		// ---- OLD CODE ALERT ----


				// STEP 1:
				// transform.position = Vector3.MoveTowards (transform.position, _currentTarget, Time.deltaTime * 5);

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


		// ---- END OLD CODE ----


		// How far is our player from the destination?
		float distanceToTarget = Vector3.Distance (transform.position, _currentTarget);

		// If we're still far enough away, tell nav mesh to move us towards target
		if (distanceToTarget > 0.5f)
		{
			agent.SetDestination (_currentTarget);
		}
	}

	#endregion
}
