using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenFollow : MonoBehaviour {

	public Transform target;

	public Transform myTransform;

	void Start () {

		target = gameobject.findwithtag("Player").transform;
		
	}
	

	void Update () {
		transform.Lookat (target);
		transform.Translate (Vector3.forward * Time.deltaTime);	
	}
}
