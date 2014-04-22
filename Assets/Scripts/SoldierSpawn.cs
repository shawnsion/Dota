using UnityEngine;
using System.Collections;

public class SoldierSpawn : MonoBehaviour {
	public Rigidbody soldierPrefab;
	public GameObject tower;
	float timer;
	float waveTimer;
	int spawnCounter;
	bool inWave;
	TowerInfo towerInfo;
	// Use this for initialization
	void Start () {
		timer = 0.0f;
		waveTimer = 0.0f;
		inWave = false;
		towerInfo = tower.GetComponent<TowerInfo> ();
		spawnCounter = towerInfo.spawnAmount;
	}
	
	// Update is called once per frame
	void Update () {
		if (towerInfo.affiliation != MapInfo.Affiliation.none) {
			timer += Time.deltaTime;
			waveTimer += Time.deltaTime;
			if(waveTimer >= towerInfo.waveInterval){
				inWave = true;
			}
			if (inWave && timer >= towerInfo.spawnInterval) {
				spawnSoldier();
				spawnCounter--;
			}
			if(spawnCounter == 0){
				spawnCounter = towerInfo.spawnAmount;
				inWave = false;
				waveTimer = 0;
			}
		}
	}

	void spawnSoldier(){
		Rigidbody soliderInstance;
		soliderInstance = Instantiate (soldierPrefab, transform.position, transform.rotation) as Rigidbody;
				
		SoldierInfo soldierInfo = soliderInstance.GetComponent<SoldierInfo> ();
		soldierInfo.spawnTower = tower;
		soldierInfo.target = tower.GetComponent<TowerInfo> ().target;
		soldierInfo.affiliation = tower.GetComponent<TowerInfo> ().affiliation;
		timer = 0.0f;
	}
}
