using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assessment1{
	public class JumpLevelGenerator : MonoBehaviour {

		public GameObject jumpPlatformPrefab;

		public int numberOfPlatforms = 20;
		public float levelWidth = 3f;
		public float minY = 10f;
		public float maxY = 20f;

		// Use this for initialization
		void Start()
		{
			Vector3 spawnPosition = new Vector3();

			for (int i = 0; i < numberOfPlatforms; i++)
			{
				spawnPosition.y += Random.Range(minY, maxY);
				spawnPosition.x = Random.Range(-levelWidth, levelWidth);
				Instantiate(jumpPlatformPrefab, spawnPosition, Quaternion.identity);
			}
		}
	}
}
