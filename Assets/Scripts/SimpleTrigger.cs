using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTrigger : MonoBehaviour {

	public int triggerNumber;
	public bool ballSunk = false;
	public bool ballIn = false;
	public bool ballOut = false;
	public bool tetrisHit = false;
	public bool tetrisHitBall = false;
	public bool inTube = false;
	public bool targetHit = false;

	public GameObject barricade1;
	public GameObject barricade2;
	public GameObject barricade3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(ballOut){
			Destroy (barricade1);
		}

		if(tetrisHitBall){
			Destroy (barricade2);
		}

		if(targetHit){
			Destroy (barricade3);
		}
		
	}

	void OnTriggerEnter (Collider triggerHittingMe){
		Debug.Log (triggerHittingMe.name + ",shit works");

		if(triggerHittingMe.gameObject.tag == "Ball" && triggerNumber == 1){
			Debug.Log ("Ball Sunk");
			ballSunk = true;
		} 
		if (triggerHittingMe.gameObject.tag == "Ball" && triggerNumber == 2){
			Debug.Log ("Ball In");
			ballIn = true;
			ballSunk = false;
		} 
		if (triggerHittingMe.gameObject.tag == "Ball" && triggerNumber == 3){
			ballIn = false;
			ballOut = true;
		}
		if(triggerHittingMe.gameObject.tag == "Tetris" && triggerNumber == 4){
			tetrisHit = true;
			ballOut = false;
		}
		if(triggerHittingMe.gameObject.tag == "Tetris" && triggerNumber == 5){
			tetrisHit = false;
			tetrisHitBall = true;
		}
		if(triggerHittingMe.gameObject.tag == "Basket" && triggerNumber == 6){
			inTube = true;
			tetrisHitBall = false;
		}
		if(triggerHittingMe.gameObject.tag == "Basket" && triggerNumber == 7){
			targetHit = true;
			inTube = false;
		}
	}


}
