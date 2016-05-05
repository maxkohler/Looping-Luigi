using UnityEngine;
using System.Collections;

public class CoinSound : MonoBehaviour {

	public GameObject go;

	// Use this for initialization
	void Start ()
	{
		go = GameObject.Find("achse_cone");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.CompareTag("Luigi"))
		{
			GetComponent<AudioSource>().Play();
		}
	}
}
