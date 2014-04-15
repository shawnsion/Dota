using UnityEngine;
using System.Collections;

public class Camp : MonoBehaviour {
	public GameObject tower;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		TowerInfo towerInfo = tower.GetComponent<TowerInfo> ();
		if (towerInfo.affiliation == MapInfo.Affiliation.none) {
			particleSystem.startColor = MapInfo.white;
		}
		if (towerInfo.affiliation == MapInfo.Affiliation.red) {
			particleSystem.startColor = MapInfo.red;
		}
		if (towerInfo.affiliation == MapInfo.Affiliation.blue) {
			particleSystem.startColor = MapInfo.blue;
		}
	}
}
