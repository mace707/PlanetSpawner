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

		Transform positionTransform = Positions[randPosition].transform;
		GameObject spawnedPlanet = (GameObject)Instantiate(Planets[randPlanet], positionTransform.position, Quaternion.identity);
		spawnedPlanet.transform.SetParent(positionTransform);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
