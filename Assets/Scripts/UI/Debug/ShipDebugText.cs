using UnityEngine;
using UnityEngine.UI;

public class ShipDebugText : MonoBehaviour
{
	[SerializeField]
	private ShipMovementController ship;

	private Text text;

	private void Awake()
	{
		text = gameObject.GetComponent<Text>();
	}

	private void Update()
	{
		text.text = "Debug";
	}

}
