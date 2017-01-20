using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour 
{

	public GameObject[] Planets;
	public PlanetPosition[] Positions;

	// Use this for initialization
	void Start () 
	{
		int randPosition = Random.Range(0, 4);
		int randPlanet = Random.Range(0, 4);

		Vector3 spawnPosition = Positions[randPosition].transform.position;
		Instantiate(Planets[randPlanet], spawnPosition, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
