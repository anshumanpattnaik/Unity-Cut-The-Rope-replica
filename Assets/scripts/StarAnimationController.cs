using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAnimationController : MonoBehaviour {

	Animator animator;

	void Start(){
		animator = GetComponent<Animator> ();
	}

	void Update () {
		Debug.Log ("Star : "+StarController.isStarCollision);
		if (StarController.isStarCollision) {
			//animator.Play ("StarDisappearAnimation");
		}
	}
}