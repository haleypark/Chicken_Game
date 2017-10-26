using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenFollow : MonoBehaviour {

	// public Transform player;

	// public Transform chicken;

	// void Start () {

	// 	player = GameObject.FindWithTag("Player").transform;
		
	// }
	

	// void Update () {
	// 	transform.LookAt (player);
	// 	transform.Translate (Vector3.forward * Time.deltaTime);	
	// }

	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;

	public Transform chickenPen;

	void OnTriggerStay(Collider other){
		if(other.gameObject.name == "Player" || other.gameObject.name == "Puppy"){
			Debug.Log("Player has entered chickens trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
		else()
	}
	void OnCollisionEnter(Collision other){
		if(other.gameObject.name == "Player"){
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
		}
		//destroy(gameObject);
		//scoremanager.AddPoints(points);
	}


}

