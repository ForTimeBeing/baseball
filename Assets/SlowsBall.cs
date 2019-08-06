using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowsBall : MonoBehaviour {
	Rigidbody myRigidBody;
	public Transform prefab;
	bool canSpawn = true;
	// Use this for initialization
	void Start () {
		Rigidbody x = GetComponent<Rigidbody>();
		setRigidBody(x);
	}
	
	//spawns new ball
	void OnCollisionEnter(Collision other){

		if (other.gameObject.name == "floor" && canSpawn == true){
			canSpawn = false;
			Instantiate(prefab, new Vector3(2.2957f, 1.5f, 2.1f), Quaternion.identity);
			StartCoroutine(DestroyBall());
		}
	}
	//slows ball down
	void OnCollisionStay(Collision other){
		if (other.gameObject.name == "floor" && myRigidBody.drag < 5){
			myRigidBody.drag += .05f;
		}
	}
	//sets ball back to normal physics
	void OnCollisionExit(Collision other){
		if (other.gameObject.name == "floor"){
			myRigidBody.drag = 0;
		}
	}
	IEnumerator DestroyBall()
    {
		yield return new WaitForSeconds(5);
		Destroy(gameObject);
	}
	//setter
	void setRigidBody(Rigidbody x){
		myRigidBody = x;
	}
}
