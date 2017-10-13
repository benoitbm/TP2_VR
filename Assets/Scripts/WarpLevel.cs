using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WarpLevel : MonoBehaviour
{
	[SerializeField] private string nomNiv = "wizardroom";

	[Header("Gameplay")] [SerializeField] private float coinsToCollect = 5;
	[SerializeField] private float timeMin = 60f;
	private float timeRemain;
	
	[Header("UI")] [SerializeField] private Text collectRemain;
	[SerializeField] private Image timeBar;

	private void Start()
	{
		timeRemain = timeMin;
	}

	void FixedUpdate()
	{
		timeRemain -= Time.fixedDeltaTime;

		timeBar.fillAmount = timeRemain / timeMin;

		collectRemain.text = coinsToCollect <= 0 ? "I can pay the toll !" : "Coins needed : " + coinsToCollect;

		if (timeRemain <= 0)
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		
	}

	private void OnTriggerEnter(Collider other)
	{
		print(other.name);
		if (other.CompareTag("Player") && coinsToCollect <= 0)
			SceneManager.LoadScene(nomNiv);
		else if (other.CompareTag("Player") )
			print("Not enough coins to pay the toll !");
	}

	public void coinCollected()
	{
		coinsToCollect--;
	}
}
