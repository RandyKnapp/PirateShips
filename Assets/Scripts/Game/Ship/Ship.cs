using UnityEngine;
public class Ship : MonoBehaviour
{
	[SerializeField]
	private Team team;

	public Team Team { get { return team; } }
}
