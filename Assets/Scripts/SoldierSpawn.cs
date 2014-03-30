using UnityEngine;
using System.Collections;

public class SoldierSpawn : MonoBehaviour {
	public Rigidbody soldierPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Q))
		{
			Rigidbody soliderInstance;
			soliderInstance = Instantiate(soldierPrefab, transform.position, transform.rotation) as Rigidbody;
			//rocketInstance.AddForce(barrelEnd.forward * 5000);
		}
	}
}
