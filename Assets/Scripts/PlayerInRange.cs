using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerInRange : MonoBehaviour {
	public GameObject tower;
	float timer;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay (Collider col) {
		if (col.gameObject.tag == "Player") 
		{
			PlayerInfo playerInfo = col.gameObject.GetComponent<PlayerInfo>();
			TowerInfo towerInfo = tower.GetComponent<TowerInfo>();
			if(playerInfo.affiliation != towerInfo.affiliation){
				if(playerInfo.timer > 0.0)
					playerInfo.timer -= Time.deltaTime;
				else
				{
					playerInfo.timer = 0.0;
					towerInfo.affiliation = playerInfo.affiliation;
					findNewTarget();
				}
			}
		}
	}

	void OnTriggerExit (Collider col){
		if (col.gameObject.tag == "Player") 
		{
			PlayerInfo playerInfo = col.gameObject.GetComponent<PlayerInfo>();
			playerInfo.timer = playerInfo.maxTimer;
		}
	}

	void findNewTarget(){
		GameObject[] towerList = GameObject.FindGameObjectsWithTag("Tower");
		TowerInfo towerInfo = tower.GetComponent<TowerInfo> ();
		List<KeyValuePair<float, GameObject> > targetList = new List<KeyValuePair<float, GameObject> >();
		foreach (GameObject target in towerList) {
			TowerInfo targetInfo = target.GetComponent<TowerInfo> ();

			if(!target.Equals(tower) && !targetInfo.affiliation.Equals(towerInfo.affiliation) ){
				targetList.Add(new KeyValuePair<float, GameObject>
				              (Vector3.Distance(transform.position, target.transform.position),target));
				//towerInfo.target = target;
			}
		}
		targetList.Sort ((x, y) => x.Key.CompareTo(y.Key));
		towerInfo.target = targetList[0].Value;
	}
}
