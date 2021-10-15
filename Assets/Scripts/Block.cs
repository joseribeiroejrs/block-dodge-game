using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
	public Rigidbody2D blockRigidyBody;
	private void Start()
	{
		blockRigidyBody.gravityScale = 1f + Time.timeSinceLevelLoad / 20f;
	}

	private void Update()
	{
		if (transform.position.y < -8f)
		{
			Destroy(gameObject);
		}
	}
}
