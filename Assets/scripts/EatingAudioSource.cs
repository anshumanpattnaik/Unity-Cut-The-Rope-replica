using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingAudioSource : MonoBehaviour {

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		audioSource.clip = Resources.Load<AudioClip>("monster_chewing");
	}

	// Update is called once per frame
	void Update () {
		if(TriggerAnimation.isHungryAnimation){
			audioSource.Play ();
		}
	}
}