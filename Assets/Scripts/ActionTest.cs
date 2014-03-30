using UnityEngine;
using System.Collections;

public class ActionTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Q))
		{
			animation.CrossFade("sprint");
		}
		if(Input.GetKey(KeyCode.E))
		{
			animation.CrossFade("run");
		}
	}
}
