using UnityEngine;
using System.Collections;

public class powerswitch : MonoBehaviour
{
	private GameObject achse;
	private GameObject smoke;
	private GameObject prop;

	private Animator switchAnimator;


	// Use this for initialization
	void Start ()
	{
		switchAnimator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnMouseDown()
	{
		achse = GameObject.Find("achse_cone");
		smoke = GameObject.Find("Rauch");
		prop = GameObject.Find("Propeller_2");


		if(achse.GetComponent<RotateConeAchse>().enabled == true)
		{
			achse.GetComponent<RotateConeAchse>().enabled = false;
			switchAnimator.SetBool("on", false);
			smoke.GetComponent<ParticleSystem>().enableEmission = false;
			prop.GetComponent<propeller>().enabled = false;
		}
		else
		{
			achse.GetComponent<RotateConeAchse>().enabled = true;
			switchAnimator.SetBool("on", true);
			smoke.GetComponent<ParticleSystem>().enableEmission = true;
			prop.GetComponent<propeller>().enabled = true;
		}
	}
}
