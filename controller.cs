using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
	Rigidbody rb;
	public Transform transf;
	Transform tr;
	float fire;
	float v;
	float x;
	Rigidbody clone;
	public Rigidbody obj;
	void Start () {
		rb = GetComponent<Rigidbody>();
		tr = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		v = Input.GetAxis ("Vertical");
		fire = Input.GetAxis ("Fire1");
		Vector3 force = new Vector3 (0, 5, v);
		rb.AddForce (tr.forward * v * 150f);
		x = Input.GetAxis ("Mouse X");
		Vector3 rotation = new Vector3 (0, x, 0);
		tr.Rotate (rotation * 10f);
		if (fire > 0) {
			clone = Instantiate (obj, transf.position, transf.rotation);
			clone.AddForce (tr.forward * 6000f);
		}
	}
}
