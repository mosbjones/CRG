using UnityEngine;
using System.Collections;

public class MoveCollider : MonoBehaviour {
	

	void FixedUpdate(){
		float xAxis = Input.GetAxis("Horizontal");
		float yAxis = Input.GetAxis("Vertical");

		Vector3 dir = new Vector3(yAxis, 0f, xAxis * -1);

		transform.Translate(dir*Time.deltaTime * 10f);
	}
}
