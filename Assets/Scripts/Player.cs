using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D playerRigidyBody;
	public float limitMap = 16.8f;
    public float horizontalMovementForce = 20f;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
		movementHorizontal();
	}

	float getHorizontalMove()
	{
        return Input.GetAxis("Horizontal");
	}

    void movementHorizontal()
	{
		float movementForce = getHorizontalMove() * Time.fixedDeltaTime * horizontalMovementForce;
		Vector2 newPosition = playerRigidyBody.position + Vector2.right * movementForce;
		newPosition.x = Mathf.Clamp(newPosition.x, -limitMap, limitMap);

		playerRigidyBody.MovePosition(newPosition);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		FindObjectOfType<GameManager>().EndGame();
	}
}
