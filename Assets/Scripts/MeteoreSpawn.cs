using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoreSpawn : MonoBehaviour
{

	[Header("Parametres prefab")] [SerializeField] private GameObject meteore;

	[Header("Limites spawn")] [SerializeField] private Vector2 min;
	[SerializeField] private Vector2 max;
	[SerializeField] [Range(0, 10)] private float tpsAttente = 1f;
	[SerializeField] private float height = 3;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("spawnMeteore", 0, tpsAttente);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void spawnMeteore()
	{
		Vector3 pos = new Vector3(Random.Range(min.x, max.x), height, Random.Range(min.y, max.y));
		GameObject obj = Instantiate(meteore, pos, Quaternion.identity);
		
		Destroy(obj, 10); //Détruire l'objet au bout de 10s
	}
}
