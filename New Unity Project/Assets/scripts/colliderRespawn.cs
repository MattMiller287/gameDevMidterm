using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderRespawn : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		Vector3 spawn = new Vector3(0.0f, 1.2f, -4.3f);
		deathCounter.deaths += 1;
		other.transform.position = spawn;
	}
}
