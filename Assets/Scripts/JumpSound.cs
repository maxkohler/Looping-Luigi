using UnityEngine;
using System.Collections;

public class JumpSound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.CompareTag("Luigi"))
		{
			GetComponent<AudioSource>().Play();
		}
	}
}
