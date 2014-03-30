using UnityEngine;
using System.Collections;

public class SoldierAI : MonoBehaviour {
	public float speed;
	public float force;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		GameObject target = GameObject.FindWithTag("Player");
		GameObject player = GameObject.FindWithTag("Player");
		if (target != null)
		{
			Vector3 direction = target.transform.position - transform.position;
			transform.rotation = Quaternion.LookRotation(direction);
			transform.position += transform.forward * speed;/*
			if(Vector3.Distance(player.transform.position, transform.position) < 2){
				CharacterController controller = player.GetComponent<CharacterController>();
				controller.SimpleMove(direction.normalized * force);
			}*/
		}
	}
}
