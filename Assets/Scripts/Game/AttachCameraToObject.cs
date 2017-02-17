using UnityEngine;

public class AttachCameraToObject : MonoBehaviour
{
	[SerializeField]
	private Transform objectToFollow;

	private void FixedUpdate()
	{
		transform.position = objectToFollow.position + new Vector3(0, 0, -10);
	}
}
