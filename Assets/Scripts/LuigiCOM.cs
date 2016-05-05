using UnityEngine;
using System.Collections;

public class LuigiCOM : MonoBehaviour
{

	Rigidbody rb;
	public Vector3 com;
	
	// Use this for initialization
	void Start ()
	{
		com  = new Vector3(0,-10,0);
		rb = GetComponent<Rigidbody>();
		rb.centerOfMass = com;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
