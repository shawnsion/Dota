using UnityEngine;
using System.Collections;

public class SoldierInfo : MonoBehaviour {
	public float speed;
	public float force;
	public GameObject spawnTower;
	public GameObject target;
	public MapInfo.Affiliation affiliation;
	public GameObject feature;
	public float searchRange;
	public float attackRange;
	// Use this for initialization
	void Start () {
		if (affiliation == MapInfo.Affiliation.red) {
			feature.renderer.material.color = MapInfo.red;
		}
		if (affiliation == MapInfo.Affiliation.blue) {
			feature.renderer.material.color = MapInfo.blue;
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
