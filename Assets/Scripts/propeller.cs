using UnityEngine;
using System.Collections;

public class propeller : MonoBehaviour
{
	private float speed;
	void Start ()
	{
	
	}

	void Update ()
	{
		speed = 500 + Time.time;
		transform.Rotate(Vector3.right, speed * Time.deltaTime, Space.Self);
	}
}
