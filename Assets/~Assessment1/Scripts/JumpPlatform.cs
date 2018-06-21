using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assessment1
{
	public class JumpPlatform : MonoBehaviour
	{

		public float jumpPush = 30f;

		void OnCollisionEnter2D(Collision2D jump) // Detects collisions entering and forces detected collision to "Jump up"
		{
			if (jump.relativeVelocity.y >= 0f)
			{
				Rigidbody2D rb = jump.collider.GetComponent<Rigidbody2D>();
				if (rb != null)
				{
					Vector2 velocity = rb.velocity;
					velocity.y = jumpPush;
					rb.velocity = velocity;
				}
			}
		}
	}
}