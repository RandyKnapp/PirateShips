using System;
using UnityEngine;

public class CannonComposition : MonoBehaviour
{
	[Serializable]
	struct CannonContainers
	{
		public GameObject PortCannons;
		public GameObject StarboardCannons;
		public GameObject BowCannons;
		public GameObject SternCannons;
	}

	[Serializable]
	struct CannonAssets
	{
		public GameObject CannonPrefab;
	}

	[Serializable]
	struct CannonData
	{
		public int PortCannonCount;
		public int StarboardCannonCount;
		public int BowCannonCount;
		public int SternCannonCount;
	}

	[SerializeField]
	private CannonContainers cannonContainers;
	[SerializeField]
	private CannonAssets cannonAssets;
	[SerializeField]
	private CannonData cannonData;

	private void Awake()
	{
	}

	public void DoComposition()
	{
	}

}
