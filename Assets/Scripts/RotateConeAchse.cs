using UnityEngine;
using System.Collections;

public class RotateConeAchse : MonoBehaviour
{
	private Vector3 vec;
	private float speed;
	// Use this for initialization
	void Start ()
	{
		vec = new Vector3(0, -1, 0);
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		speed = 30 + Time.time;
		//transform.Rotate(Vector3.right, 50 * Time.deltaTime, Space.Self);
		transform.eulerAngles += (vec * Time.deltaTime * speed);
	}
}