using UnityEngine;
using System.Collections;

public class FlipGelb : MonoBehaviour {

	Rigidbody rb;
	public Vector3 com;
	
	// Use this for initialization
	void Start ()
	{
		com  = new Vector3(0,0,0);
		rb = GetComponent<Rigidbody>();
		rb.centerOfMass = com;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//transform.eulerAngles = new Vector3(Mathf.Clamp(transform.eulerAngles.x, 1.0F, 325.0F), transform.eulerAngles.y, transform.eulerAngles.z);
		if(Input.GetKey(KeyCode.RightShift))
		{
			rb.AddRelativeTorque(transform.forward * 50000);
		}
	}
}
