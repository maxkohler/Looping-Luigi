using UnityEngine;
using System.Collections;

public class CameraRotator : MonoBehaviour
{
	void Update ()
	{
		transform.RotateAround (Vector3.zero, Vector3.up, -1.0f);
	}
}
