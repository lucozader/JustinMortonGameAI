using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	public AudioClip music;
	// Use this for initialization
	void Start () {
		audio.PlayOneShot(music);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
