using System;
using UnityEngine;

public class ShipComposer : MonoBehaviour
{
	[Serializable]
	struct Composition
	{
		public GameObject Container;
		public GameObject Prefab;
	}

	[SerializeField]
	private Composition hull;
	[SerializeField]
	private Composition mainsail;
	[SerializeField]
	private Composition foresail;

	private void Awake()
	{
		Compose(hull);
		Compose(mainsail);
		Compose(foresail);
	}

	private void Compose(Composition composition)
	{
		GameObject createdObject = Instantiate(composition.Prefab);
		createdObject.transform.SetParent(composition.Container.transform, false);
	}
}
