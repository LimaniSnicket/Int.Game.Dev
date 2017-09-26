using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//move camera & shit like that

public class CameraControl : MonoBehaviour {

	public SimpleTrigger trigger1;
	public SimpleTrigger trigger2;
	public SimpleTrigger trigger3;
	public SimpleTrigger trigger4;
	public SimpleTrigger trigger5;
	public SimpleTrigger trigger6;
	public SimpleTrigger trigger7;

	public Transform lookAtTarget; //what is camera supposed to look at
	public Transform moveToTarget; //where is camera supposed to go

	public Transform lookAtTargetTwo;
	public Transform moveToTargetTwo;

	public Transform lookAtTargetThree;
	public Transform moveToTargetThree;

	public Transform lookAtTargetFour;
	public Transform moveToTargetFour;

	public Transform lookAtTargetFive;
	public Transform moveToTargetFive;

	public Transform lookAtTargetSix;
	public Transform moveToTargetSix;

	public Transform lookAtTargetSeven;
	public Transform moveToTargetSeven;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (trigger1.ballSunk && trigger1.triggerNumber == 1) {
			//is lookAtTarget defined
			if (lookAtTarget != null) {
				transform.LookAt (lookAtTarget.position);
			}
			//is movetotarget still defined and does it exist
			if (moveToTarget != null) {
				//make this transform move towards the thing 
				//first calc. vector from camera.A to camera.B
				Vector3 moveDirection = moveToTarget.position - transform.position;
				//is the move direction >1? if so normalize it (change its magnitude to 1)
				if (moveDirection.magnitude > 1f) {
					moveDirection = moveDirection.normalized; 
				}
				//move transform towards destination
				transform.position += moveDirection * Time.deltaTime * 10f;
			}
		} 
		if (trigger2.ballIn && trigger2.triggerNumber == 2) {
			
			if (lookAtTarget != null) {
				transform.LookAt (lookAtTargetTwo.position);
			}
			if (moveToTarget != null) {
				Vector3 moveDirection = moveToTargetTwo.position - transform.position;
				if (moveDirection.magnitude > 1f) {
					moveDirection = moveDirection.normalized; 
				}
				transform.position += moveDirection * Time.deltaTime * 10f;
				trigger1.ballSunk = false;
			}
		}
		 if (trigger3.ballOut && trigger3.triggerNumber == 3) {

			if (lookAtTarget != null) {
				transform.LookAt (lookAtTargetThree.position);
			}
			if (moveToTarget != null) {
				Vector3 moveDirection = moveToTargetThree.position - transform.position;
				if (moveDirection.magnitude > 1f) {
					moveDirection = moveDirection.normalized; 
				}
				transform.position += moveDirection * Time.deltaTime * 10f;
				trigger2.ballIn = false;
			}
		}
		if (trigger4.tetrisHit && trigger4.triggerNumber == 4) {

			if (lookAtTarget != null) {
				transform.LookAt (lookAtTargetFour.position);
			}
			if (moveToTarget != null) {
				Vector3 moveDirection = moveToTargetFour.position - transform.position;
				if (moveDirection.magnitude > 1f) {
					moveDirection = moveDirection.normalized; 
				}
				transform.position += moveDirection * Time.deltaTime * 10f;
				trigger3.ballOut = false;
			}
		}
		if (trigger5.tetrisHitBall && trigger5.triggerNumber == 5) {

			if (lookAtTarget != null) {
				transform.LookAt (lookAtTargetFive.position);
			}
			if (moveToTarget != null) {
				Vector3 moveDirection = moveToTargetFive.position - transform.position;
				if (moveDirection.magnitude > 1f) {
					moveDirection = moveDirection.normalized; 
				}
				transform.position += moveDirection * Time.deltaTime * 10f;
				trigger4.tetrisHit = false;
			}
		}
		if (trigger6.inTube && trigger6.triggerNumber == 6) {

			if (lookAtTarget != null) {
				transform.LookAt (lookAtTargetSix.position);
			}
			if (moveToTarget != null) {
				Vector3 moveDirection = moveToTargetSix.position - transform.position;
				if (moveDirection.magnitude > 1f) {
					moveDirection = moveDirection.normalized; 
				}
				transform.position += moveDirection * Time.deltaTime * 10f;
				trigger5.tetrisHitBall = false;
			}
		}
		if (trigger7.targetHit && trigger7.triggerNumber == 7) {

			if (lookAtTarget != null) {
				transform.LookAt (lookAtTargetSeven.position);
			}
			if (moveToTarget != null) {
				Vector3 moveDirection = moveToTargetSeven.position - transform.position;
				if (moveDirection.magnitude > 1f) {
					moveDirection = moveDirection.normalized; 
				}
				transform.position += moveDirection * Time.deltaTime * 10f;
				trigger6.inTube = false;
			}


		}

		

	}
}
