using UnityEngine;
using System.Collections;

public class PlayTieNoiseatTime : MonoBehaviour {
	float timer;
	public AudioClip sound;
	bool playSoundOnce = false;
	public AudioClip moon;
	bool playMoonSoundOnce = false;
	public AudioClip vader;
	bool playVaderSoundOnce = false;


	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer = timer +1*Time.deltaTime;
		Debug.Log(timer);
		if(timer >20 && playSoundOnce == false){
			audio.PlayOneShot(sound);
		   playSoundOnce = true;
		}
		if(timer >25 && playMoonSoundOnce == false){
			audio.PlayOneShot(moon);
			playMoonSoundOnce = true;
		}

		if(timer >7 && playVaderSoundOnce == false){
			audio.PlayOneShot(vader);
			playVaderSoundOnce = true;
		}
	
	}
}
