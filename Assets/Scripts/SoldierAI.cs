using UnityEngine;
using System.Collections;

public class SoldierAI : MonoBehaviour {
	public GameObject soldier;
	public enum State{move,stand,attack};
	State state;
	// Use this for initialization
	void Start () {
		state = State.move;
	}
	
	// Update is called once per frame
	void Update () {
		SoldierInfo soldierInfo = soldier.GetComponent<SoldierInfo> ();
		GameObject target = soldier.GetComponent<SoldierInfo>().target;
		if (target != null)
		{
			Vector3 direction = target.transform.position - transform.position;
			direction.y = 0;
			direction.Normalize();
			if (Vector3.Distance (transform.position, target.transform.position) <= soldierInfo.attackRange) {
				state = State.stand;
				animation.CrossFade("idle");
			}
			else{
				state = State.move;
				animation.CrossFade("run");
			}
			switch(state)
			{
				case State.move:
					transform.rotation = Quaternion.LookRotation(direction);
					transform.position += transform.forward.normalized * soldierInfo.speed;
					break;
				case State.stand:
					transform.rotation = Quaternion.LookRotation(direction);
					break;
					
			}
		}
	}
	void OnTriggerEnter(Collider col){
		SoldierInfo soldierInfo = soldier.GetComponent<SoldierInfo> ();
		if (soldierInfo.target.tag != "NonPlayer") {
			if(col.gameObject.tag == "NonPlayer"){
				SoldierInfo colliderInfo = col.gameObject.GetComponent<SoldierInfo>();
				if(!colliderInfo.affiliation.Equals(soldierInfo.affiliation))
					soldierInfo.target = col.gameObject;
			}
			if(col.gameObject.tag == "Player"){
				PlayerInfo colliderInfo = col.gameObject.GetComponent<PlayerInfo>();
				if(!colliderInfo.affiliation.Equals(soldierInfo.affiliation))
					soldierInfo.target = col.gameObject;
			}
		}
	}
}
