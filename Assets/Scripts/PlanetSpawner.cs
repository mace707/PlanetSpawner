﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour 
{

	public GameObject[] Planets;
	public PlanetPosition[] Positions;

	private GameObject SpawnedPlanet;
	private Transform PositionTransform;

	// Use this for initialization
	void Start () 
	{
		SpawnPlanet();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(!SpawnedPlanet)
		{
			SpawnPlanet();
		}
	}

	void SpawnPlanet()
	{
		int randPosition = Random.Range(0, Positions.Length -1);
		int randPlanet = Random.Range(0, Planets.Length-1);

		Debug.Log ("Size of planet array: " + Planets.Length);

		Animator mAnimator = Positions [randPosition].GetComponent<Animator>();
		mAnimator.SetBool("IsArriving", true);

		PositionTransform = Positions[randPosition].transform;
		SpawnedPlanet = (GameObject)Instantiate(Planets[randPlanet], PositionTransform.position, Quaternion.identity);
		SpawnedPlanet.transform.SetParent(PositionTransform);
	}

}
