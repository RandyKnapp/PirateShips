using UnityEngine;

public class ShipController : MonoBehaviour
{
	const uint MaxSpeed = 3;
	const float MinTurning = -1;
	const float MaxTurning = 1;
	const float baseTurningSpeed = 2;

	[SerializeField]
	private float baseSpeed = 0.01f;
	[SerializeField]
	private float torque = 0.005f;

	private Rigidbody2D rigidBody;

	private uint speed = 0;
	private float turningValue = 0;
	private float turningTarget = 0;

	private void Awake()
	{
		rigidBody = gameObject.GetComponent<Rigidbody2D>();
	}

	public void SpeedUp()
	{
		if (speed < MaxSpeed)
		{
			speed++;
		}
	}

	public void SlowDown()
	{
		if (speed > 0)
		{
			speed--;
		}
	}

	public void TurnLeft()
	{
		turningTarget = MaxTurning;
	}

	public void TurnRight()
	{
		turningTarget = MinTurning;
	}

	public void StopTurning()
	{
		turningTarget = 0;
	}

	private void FixedUpdate()
	{
		UpdateTurning();
		UpdateVelocity();
	}

	private void UpdateTurning()
	{
		if (Mathf.Abs(turningValue - turningTarget) < Time.fixedDeltaTime)
		{
			turningValue = turningTarget;
		}
		else
		{
			float d = baseTurningSpeed * Time.fixedDeltaTime;
			turningValue = Mathf.Clamp(turningValue + (turningTarget < turningValue ? -1 : 1) * d, MinTurning, MaxTurning);
		}
	}

	private void UpdateVelocity()
	{
		if (speed > 0)
		{
			Vector2 velocity = transform.right;
			velocity.Normalize();
			velocity = velocity * speed * baseSpeed;

			//velocity = Quaternion.Euler(0, 0, turningValue * turningAngle) * velocity;

			rigidBody.AddForce(velocity, ForceMode2D.Impulse);
			rigidBody.AddTorque(turningValue * torque, ForceMode2D.Impulse);
		}
	}
}
