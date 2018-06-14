using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace Assessment1
{

	public class Coin : MonoBehaviour 
		{	
			public static int counter = 0;
			public Text counterText;

			void Start()
				{
					counter = 0;
				}
			void LateUpdate()
				{
					counterText.text = counter.ToString();
					// makes counter start at zero
				}

			void OnCollisionEnter2D(Collision2D coin) // Detects collisions entering to collect coin
		{
			
				if (coin.gameObject.tag == "Coin") // Detect if collider has the coin tag
				{ 
					Destroy (coin.gameObject); //Destroys the coin
					counter++; // Adds to the counter
				}
			if (coin.gameObject.tag == "Death") // Detect if collider has the Death tag
			{
				SceneManager.LoadScene(0); // Sends to the menu scene

			}

		}
	}
}
 