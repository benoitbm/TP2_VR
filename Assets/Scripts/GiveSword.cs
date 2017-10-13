using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveSword : MonoBehaviour
{

	[SerializeField] private float distance = 1;

	private bool epeeRecupere = false;
	private Transform joueur;
	
	// Use this for initialization
	void Start ()
	{
		joueur = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (!epeeRecupere)
		{
			var dist = Vector3.Distance(transform.position, joueur.position);
			print("Distance = " + dist);

			if (dist <= distance)
			{
				print("It's dangerous to go alone, take me !");
				epeeRecupere = true;

				transform.parent = joueur;
				transform.localPosition = new Vector3(.2f, .94f, .19f);
				transform.localRotation = Quaternion.identity;
				transform.localRotation = Quaternion.Euler(108,171,81);
			}
		}
	}
}
