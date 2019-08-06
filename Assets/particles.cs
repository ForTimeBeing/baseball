using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles : MonoBehaviour {	
	Rigidbody myRigidBody;

	ParticleSystem myParticleSystem;
	void Start(){
		Rigidbody x = GetComponent<Rigidbody>();
		setRigidBody(x);

		ParticleSystem y = GetComponent<ParticleSystem>();
		setParticleSystem(y);
	}
	void Update () {
		
		if(!myRigidBody.IsSleeping() && !myParticleSystem.isPlaying){
			myParticleSystem.Play();
		}
		if(myRigidBody.IsSleeping() && myParticleSystem.isPlaying){
				myParticleSystem.Pause();
				myParticleSystem.Clear();
			}
	}	
	void setRigidBody(Rigidbody x){
		myRigidBody = x;
	}
	void setParticleSystem(ParticleSystem y){
		 myParticleSystem = y;
	}
}
