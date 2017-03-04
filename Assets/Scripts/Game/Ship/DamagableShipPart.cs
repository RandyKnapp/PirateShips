using UnityEngine;
using UnityEngineInternal;

public class DamagableShipPart : MonoBehaviour
{
	[SerializeField]
	private GameObject noDamage;
	[SerializeField]
	private GameObject damage1;
	[SerializeField]
	private GameObject damage2;
	[SerializeField]
	private GameObject dead;

	private int currentDamage;
	private GameObject[] damagedParts;

	private void Awake()
	{
		damagedParts = new[] {
			noDamage,
			damage1,
			damage2,
			dead
		};

		SetDamage(0);
	}

	private void SetDamage(int damage)
	{
		currentDamage = damage;
		for (int i = 0; i < damagedParts.Length; i++)
		{
			GameObject damagedPart = damagedParts[i];
			if (damagedPart != null)
			{
				damagedPart.gameObject.SetActive(i == currentDamage);
			}
		}
	}

	public void SetDamage(float damage)
	{
		damage = Mathf.Clamp(damage, 0.0f, 1.0f);

		if (damage == 0)
		{
			SetDamage(0);
		}
		else if (damage == 1)
		{
			SetDamage(3);
		}
		else if (damage < 0.5)
		{
			SetDamage(1);
		}
		else
		{
			SetDamage(2);
		}
	}
}
