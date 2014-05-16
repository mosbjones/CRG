using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

	void OnParticleCollision(GameObject other) {
		Rigidbody body = other.rigidbody;
		if (body) {
			Vector3 direction = other.transform.position - transform.position;
			direction = direction.normalized;
			body.AddForce(direction * 5);
			Debug.Log("HIT");
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
