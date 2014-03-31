using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	float mass;
	float maxSpeed;
	Vector3 velocity = Vector3.zero;
	Vector3 force = Vector3.zero;
	int currentWaypoint = 0;
	public GameObject[] waypoints;//i can also edit this array in the unity editor
	//float theta = (3.141592654*2)/10;
	float theta = (Mathf.PI*2)/10;//i guessed it :) y = 10*costheta x = 10 * sintheta
	int currentPathPosition = 0;//this keeps track of what path point the sphere is currently seeking
	// Use this for initialization

	Vector3 Seek(Vector3 target){//seek method
		Vector3 desired = target-transform.position;
		desired.Normalize();
		desired = desired*maxSpeed;
		return(desired-velocity);
	}
	
	Vector3 FollowPath(){
		if((waypoints[currentPathPosition].transform.position-transform.position).magnitude<1f){//distance between path point and object <1
			if(currentPathPosition == waypoints.Length-1){
				currentPathPosition = 0;
			}
			currentPathPosition = currentPathPosition+1;
		}
		return(Seek(waypoints[currentPathPosition].transform.position));
	}
	
	void Start () {
		mass = 1;
		maxSpeed = 10;
	}
	
	// Update is called once per frame
	void Update () {
		force = force+FollowPath();
		//force = force+Seek ();//testing
		Vector3 accel = force/mass;
		velocity = velocity + accel*Time.deltaTime;
		transform.position= transform.position+ velocity*Time.deltaTime;
		force = Vector3.zero;
		if(velocity.magnitude>float.Epsilon){
		transform.forward = Vector3.Normalize(velocity);
		}
		velocity = velocity*0.99f;//damping
		
		
	}
}