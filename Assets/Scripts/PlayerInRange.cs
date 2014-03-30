using UnityEngine;
using System.Collections;

public class PlayerInRange : MonoBehaviour {
	public GameObject tower;
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
			Camp towerInfo = tower.GetComponent<Camp>();
			if(playerInfo.affiliation != towerInfo.affiliation){
				if(playerInfo.timer > 0.0)
					playerInfo.timer -= Time.deltaTime;
				else
				{
					playerInfo.timer = 0.0;
					towerInfo.affiliation = playerInfo.affiliation;
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
}
