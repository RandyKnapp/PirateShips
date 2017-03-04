using UnityEngine;

public class PlayerShipController : MonoBehaviour
{
	private ShipMovementController shipController;

	private void Awake()
	{
		shipController = gameObject.GetComponent<ShipMovementController>();
	}

	private void Update()
	{
		if (Input.GetButtonDown("SpeedUp"))
		{
			shipController.SpeedUp();
		}
		else if (Input.GetButtonDown("SlowDown"))
		{
			shipController.SlowDown();
		}

		if (Input.GetButton("TurnLeft") && !Input.GetButton("TurnRight"))
		{
			shipController.TurnLeft();
		}
		else if (Input.GetButton("TurnRight") && !Input.GetButton("TurnLeft"))
		{
			shipController.TurnRight();
		}
		else
		{
			shipController.StopTurning();
		}
	}
}
