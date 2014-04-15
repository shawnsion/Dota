using UnityEngine;
using System.Collections;

public class SoldierSpawn : MonoBehaviour {
	public Rigidbody soldierPrefab;
	public GameObject tower;
	float timer;
	// Use this for initialization
	void Start () {
		timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		TowerInfo towerInfo = tower.GetComponent<TowerInfo> ();
		timer += Time.deltaTime;
		if(timer >= towerInfo.spawnInterval)
		{
			Rigidbody soliderInstance;
			soliderInstance = Instantiate(soldierPrefab, transform.position, transform.rotation) as Rigidbody;

			SoldierInfo soldierInfo = soliderInstance.GetComponent<SoldierInfo>();
			soldierInfo.spawnTower = tower;
			soldierInfo.target = tower.GetComponent<TowerInfo>().target;
			soldierInfo.affiliation = tower.GetComponent<TowerInfo>().affiliation;
			timer = 0.0f;
		}
	}
}
