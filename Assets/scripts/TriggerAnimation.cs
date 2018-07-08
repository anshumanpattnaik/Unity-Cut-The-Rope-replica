using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour {

	public static bool isHungryAnimation;
	public static bool isEatAnimation;
	public static bool isSadAnimation;

	void OnTriggerEnter2D(Collider2D col){
		if(gameObject.name == "HungryAnimation"){
			isHungryAnimation = true;
		}
		if(gameObject.name == "EatAnimation"){
			isEatAnimation = true;
		}
		if(gameObject.name == "SadAnimation"){
			isSadAnimation = true;
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(gameObject.name == "HungryAnimation"){
			isHungryAnimation = false;	
		}
		if(gameObject.name == "SadAnimation"){
			//isSadAnimation = false;	
		}
	}
}