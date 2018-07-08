using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

	private Animator animator;

	void Start(){
		animator = GetComponent<Animator> ();
	}
	
	void Update () {
		if (TriggerAnimation.isHungryAnimation) {
			animator.Play ("HungryAnimation");
		}else if (TriggerAnimation.isEatAnimation) {
			animator.Play ("EatAnimation");
		}else if (TriggerAnimation.isSadAnimation) {
			animator.Play ("SadAnimation");
		}else {
			animator.Play ("IdleAnimation");
		}
	}
}