using UnityEngine;
using UnityEngine.UI;
using System.Collections;


[RequireComponent(typeof(AudioSource))]
public class CoinGetroffen : MonoBehaviour
{
	private Animator coinAnimator;

	public Text leben_player_1;
	public Text leben_player_2;
	public Text leben_player_3;
	public Text leben_player_4;

	private int punkte_player_1;
	private int punkte_player_2;
	private int punkte_player_3;
	private int punkte_player_4;
	

	private GameObject go;

	void Start ()
	{
		AudioSource audio = GetComponent<AudioSource>();

		punkte_player_1 = 3;
		punkte_player_2 = 3;
		punkte_player_3 = 3;
		punkte_player_4 = 3;
	}

	void Update ()
	{
		if(punkte_player_1 > 0)
		{
			leben_player_1.text = "Coins: " + punkte_player_1.ToString();
		}
		else
		{
			leben_player_1.text = "verloren";
			go = GameObject.Find("Coins_4");
			go.GetComponent<Collider>().enabled = false;
		}

		if(punkte_player_2 > 0)
		{
			leben_player_2.text = "Coins: " + punkte_player_2.ToString();
		}
		else
		{
			leben_player_2.text = "verloren";
			go = GameObject.Find("Coins_3");
			go.GetComponent<Collider>().enabled = false;
		}

		if(punkte_player_3 > 0)
		{
			leben_player_3.text = "Coins: " + punkte_player_3.ToString();
		}
		else
		{
			leben_player_3.text = "verloren";
			go = GameObject.Find("Coins_2");
			go.GetComponent<Collider>().enabled = false;
		}

		if(punkte_player_4 > 0)
		{
			leben_player_4.text = "Coins: " + punkte_player_4.ToString();
		}
		else
		{
			leben_player_4.text = "verloren";
			go = GameObject.Find("Coins");
			go.GetComponent<Collider>().enabled = false;
		}
	}
	
		
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.CompareTag("CoinPlayer1"))
		{
			punkte_player_1--;
			coinAnimator = col.gameObject.GetComponent<Animator>();
			coinAnimator.SetInteger("aniCount1", punkte_player_1);
		}
		if (col.gameObject.CompareTag("CoinPlayer2"))
		{
			punkte_player_2--;
			coinAnimator = col.gameObject.GetComponent<Animator>();
			coinAnimator.SetInteger("aniCount2", punkte_player_2);
		}
		if (col.gameObject.CompareTag("CoinPlayer3"))
		{
			punkte_player_3--;
			coinAnimator = col.gameObject.GetComponent<Animator>();
			coinAnimator.SetInteger("aniCount3", punkte_player_3);
		}
		if (col.gameObject.CompareTag("CoinPlayer4"))
		{
			punkte_player_4--;
			coinAnimator = col.gameObject.GetComponent<Animator>();
			coinAnimator.SetInteger("aniCount4", punkte_player_4);
		}
	}
}
