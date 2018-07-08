using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {

	public static bool isStarCollision;

	private Animator animator;

	private AudioSource starAudio;

	void Start(){
		animator = GetComponent<Animator> ();
		starAudio = GetComponent<AudioSource> ();

		if (gameObject.tag == "StarDisappear") {
			gameObject.SetActive (false);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		Debug.Log ("StarCollision");
		isStarCollision = true;
		starAudio.Play();
		animator.Play ("StarDisappearAnimation");
		StartCoroutine (KillOnAnimationEnd ());
	}

	private IEnumerator KillOnAnimationEnd() {
		yield return new WaitForSeconds (0.167f);
		Destroy (gameObject);
		animator.StopPlayback ();
	}
}