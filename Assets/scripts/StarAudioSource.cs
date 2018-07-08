using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAudioSource : MonoBehaviour {

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		audioSource.clip = Resources.Load<AudioClip>("star_1");
	}

	// Update is called once per frame
	void Update () {
		Debug.Log ("StarAudio : "+StarController.isStarCollision);
		if(StarController.isStarCollision){
			//playSoundAfterTenSeconds ();
			//audioSource.PlayDelayed(5);
		}
	}

	IEnumerator playSoundAfterTenSeconds()
	{
		yield return new WaitForSeconds(2);
		audioSource.Play();
	}
}