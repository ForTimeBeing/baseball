using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {
	GameObject target;
	// Use this for initialization
	void Start () {
		target = GameObject.Find("stand");

		Vector3 targetPosition = new Vector3(target.transform.position.x,
											 target.transform.position.y,
											 target.transform.position.z);

		transform.LookAt(targetPosition);
	}
}
