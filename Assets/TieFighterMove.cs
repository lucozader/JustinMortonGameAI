using UnityEngine;
using System.Collections;

public class TieFighterMove : MonoBehaviour {
	public float xPos = 30f;
	public float yPos = 5f;
	public float zPos = 200f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dest = new Vector3(30, 5, 200);
		Vector3 toDest = dest - transform.position;
		if (toDest.magnitude > 0.1f)
		{
			toDest.Normalize();
			float speed = 20.0f;
			transform.position += toDest * speed * Time.deltaTime;
			transform.forward = toDest;
		}
	
	}
}
