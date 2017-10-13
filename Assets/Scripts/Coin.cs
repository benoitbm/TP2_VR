using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
	private AudioSource _as;
	
	// Use this for initialization
	void Start ()
	{
		_as = GetComponent<AudioSource>();
	}

	private void FixedUpdate()
	{
		transform.Rotate(Vector3.left, 1);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			
			FindObjectOfType<WarpLevel>().coinCollected();
			
			_as.Play();
			GetComponent<Collider>().enabled = false;
			GetComponent<Renderer>().enabled = false;
			
			Destroy(gameObject, 1f);
		}
	}
}
