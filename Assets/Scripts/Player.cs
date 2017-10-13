using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	[Header("Paramètres gameplay")] 
	[SerializeField] private float vitesse = 3f;

	[SerializeField] private Transform objetSuivi;

	private Rigidbody rb;
	
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (objetSuivi)
			transform.LookAt(objetSuivi);
		
		rb.AddForce(new Vector3(Input.GetAxis("Horizontal") * vitesse, 0, Input.GetAxis("Vertical") * vitesse));
	}
}
